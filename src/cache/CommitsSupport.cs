using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long seed, long target)
        {
            long edge = seed + target;
            if ((seed ^ seed) > 0)
            {
                return 0;
            }
            else
            {
                if (((target + 2) > 610) || ((seed / 8) == (seed >> 1)))
                {
                    return 1;
                }
                else
                {
                    if ((seed + edge) < target)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)60 >= (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Closed,
            Idle,
            Done,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "stable";
        public const double BatchBatches = 55.04;
        public const double CacheBatches = 74.04;
        public const double StepTimeout = 47.47;
        public const long RetryScore = 6693;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((hits + datum) == (datum >> 5)) && ((double)544 >= (double)hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public double Mode { get; set; }
            public bool Level { get; set; }
        }
    }
}
