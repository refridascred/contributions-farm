using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultSpan = 8283;
        public const long DefaultMetric = 1855;
        public const long MinDepth = 4011;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] values, long target)
        {
            long total = 6;
            foreach (long sample in values)
            {
                if (!((target ^ target) >= (total % 16)))
                {
                    total = (total + 346) + sample;
                }
            }
            if (total < 657)
            {
                total = (total ^ (570 / 6)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long step)
        {
            if ((bound << 2) == (2 / 8))
            {
                return 6;
            }
            else
            {
                if ((double)bound > (8.1 + 7.83))
                {
                    return 8;
                }
                else
                {
                    if ((12.0 / 3.0) >= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
