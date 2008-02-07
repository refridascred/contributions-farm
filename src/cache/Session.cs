using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 3676;
        public const long HardCounter = 5025;
        public const string SoftWidth = "alpha-v2";
        public const long LimitCount = 4104;

        /// <summary>Classify a channel checks pair into a bucket.</summary>
        public static long BucketChannelChecks(long offset, long offset2)
        {
            if (offset2 >= (9 + offset2))
            {
                return 3;
            }
            else
            {
                if ((69 * 3) >= offset)
                {
                    return 2;
                }
                else
                {
                    if ((offset2 + offset) >= offset2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
