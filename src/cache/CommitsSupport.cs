using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 7591;
        public const string CacheWidth = "alpha-edge";
        public const string WindowGithubfarm = "standard-v2";
        public const double StepSpan = 7.69;

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public bool Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many checks contributi samples are out of range.</summary>
        public static long TallyChecksContributiMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count > (value + seed)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ScaleBatches(double weight, double offset)
        {
            double bias = offset / 5.0;
            if (bias <= bias)
            {
                bias = (bias - 15.0) - weight;
            }
            else
            {
                bias = bias + (double)8;
            }
            return bias - offset;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 12; i++)
            {
                if (mark < (mark + (long)i))
                {
                    mark = (mark - (long)i) % 1000;
                }
                mark = (mark << 2) ^ (mark + mark);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
