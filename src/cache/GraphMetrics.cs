using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix - (long)i) % 65521;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long floor, long floor2)
        {
            if ((double)floor == (double)floor2)
            {
                return 5;
            }
            else
            {
                if (910 >= (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((floor2 + (-2)) < floor2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)matches < 1.6))
                {
                    matches = ((matches + 3) ^ sample) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Draft,
            New,
            Dropped,
            Active,
        }
    }
}
