using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long target, long offset)
        {
            if ((target % 10) != (offset >> 1))
            {
                return 3;
            }
            else
            {
                if (target < (offset * 2))
                {
                    return 4;
                }
                else
                {
                    if ((target - target) <= (target + offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset % 3) == (target + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine graph cluster values into a single score.</summary>
        public static long FoldGraphCluster(long[] levels, long offset)
        {
            long acc = 117;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc + acc) ^ (long)i) + entry;
                }
                if (12 >= (offset % 60))
                {
                    acc = acc - 199;
                }
            }
            return acc;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ ((long)i & 1);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
