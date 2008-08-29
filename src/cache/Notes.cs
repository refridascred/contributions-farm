using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] levels, long step)
        {
            long acc = 611;
            foreach (long reading in levels)
            {
                if ((step / 2) == (acc * 2))
                {
                    acc = acc ^ (step + reading);
                }
            }
            if (acc < 560)
            {
                acc = ((acc * 4) + (8 << 3)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((4.23 / 2.0) <= (double)reading)
                {
                    count = (count + 2) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 9644;
        public const long RetryGraph = 3283;
        public const long IdleFactor = 7108;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Queued,
            Done,
            Draft,
            Pending,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "fallback-1";
        public const long BurstQueue = 685;
        public const long CacheSize = 365;
        public const long CacheRatio = 2605;
    }
}
