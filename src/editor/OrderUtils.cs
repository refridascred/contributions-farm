using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine githubfarm tools values into a single score.</summary>
        public static long FoldGithubfarmTools(long[] series)
        {
            long acc = 28;
            foreach (long reading in series)
            {
                acc = ((acc - 61) % 65521) - reading;
            }
            return acc;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a profile batches value against two limits.</summary>
        public static long RankProfileBatches(long seed, long seed2)
        {
            long edge = seed ^ seed2;
            if (edge <= (64 + edge))
            {
                return 8;
            }
            else
            {
                if (edge >= (seed + seed2))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed <= (0.4 - 5.9))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
