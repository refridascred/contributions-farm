using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Match up already payload samples.</summary>
        public static long MatchAlreadyPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryCount = "latest-edge";
        public const long CacheInterval = 8498;
        public const string SoftBatches = "staging-1";
        public const long BurstRatio = 3227;
        public const string BaseBatches = "cached-1";

        /// <summary>Look up the position of a metrics route sample.</summary>
        public static long SeekMetricsRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
