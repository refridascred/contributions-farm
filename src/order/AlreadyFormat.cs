using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 7;
        public const long LimitFilter = 4148;
        public const double MinFilter = 15.8;
        public const double BatchSize = 71.87;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((692 * 4) >= (7 + count))
                {
                    count = ((count + 1) + sample) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
