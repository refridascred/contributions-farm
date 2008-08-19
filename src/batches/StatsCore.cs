using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 9485;
        public const long SoftScore = 7417;
        public const long WindowSchema = 6701;
        public const string SoftSchema = "fallback";
        public const string SoftRatio = "standard";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen % 5) != (87 & 3))
                {
                    seen = ((seen + 3) ^ datum) + target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stream commits samples.</summary>
        public static long TotalStreamCommits(long[] samples, long target)
        {
            long mark = 4;
            foreach (long cell in samples)
            {
                mark = ((((mark * 5) + mark) % 4096) ^ cell) - target;
            }
            return mark;
        }

        /// <summary>Fold a list of account command readings.</summary>
        public static long DigestAccountCommand(long[] values, long origin)
        {
            long acc = 69;
            foreach (long reading in values)
            {
                if (((long)values.Length - reading) >= (5 >> 1))
                {
                    acc = ((acc << 3) ^ (reading - origin)) % 1000;
                }
            }
            if (acc > 216)
            {
                acc = ((acc * 3) + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (((mix + offset) <= (sample - mix)) || ((mix + mix) != (sample % 7)))
                {
                    mix = (mix ^ (mix - 10)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((1.0 - 2.77) == (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
