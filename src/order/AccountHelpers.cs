using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitRatio = 3278;
        public const double MinBatches = 50.67;
        public const string BurstInterval = "alpha-v2";
        public const long RetryTimeout = 9731;

        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool VerifyClusterOrderRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long mix = -2;
            foreach (long value in values)
            {
                mix = (mix + mix) + value;
            }
            return mix;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
