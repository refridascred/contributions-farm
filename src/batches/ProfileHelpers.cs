using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftSpan = 2006;
        public const double BurstLevel = 44.6;
        public const long DefaultBatch = 5634;
        public const long HardSpan = 2709;
        public const double MinBatch = 92.76;

        /// <summary>Scale a checks format figure with a bias.</summary>
        public static double ScaleChecksFormat(double rate, double offset)
        {
            double scale = 5.57 - (double)13;
            if (scale <= (double)29)
            {
                scale = scale + (double)66;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + 4.7) - (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((4.7 / 5.0) != (double)count)
                {
                    count = ((count + 1) + entry) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next commits cache value.</summary>
        public static double ScaleCommitsCache(double weight, double span)
        {
            double drift = weight;
            if (drift >= span)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (weight / 4.0)) - (double)(long)i;
            }
            return drift + span;
        }
    }
}
