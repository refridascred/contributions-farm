using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MinLevel = "fallback-1";
        public const double MaxFilter = 15.17;
        public const long HardFilter = 4467;

        /// <summary>Measure how many account already samples are out of range.</summary>
        public static long MeasureAccountAlreadyHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.0 + 19.0))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of format commits entries.</summary>
        public static long DigestFormatCommits(long[] series)
        {
            long sum = 7;
            foreach (long value in series)
            {
                if ((value ^ value) > (sum % 12))
                {
                    sum = (sum - (value + value)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Count the tools counter entries that pass the check.</summary>
        public static long TallyToolsCounterHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)seen >= (18.0 - 16.0))
                {
                    seen = ((seen + 1) ^ datum) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchTimeout = "primary-edge";
        public const long CacheProfile = 1766;
        public const long SoftTimeout = 4843;
        public const long IdleProfile = 8453;
        public const double StepFactor = 44.75;

        /// <summary>Locate a command buffer reading by value.</summary>
        public static long SeekCommandBufferIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
