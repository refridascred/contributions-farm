using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Closed,
            New,
            Pending,
            Draft,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long offset, long floor)
        {
            long prev = offset - floor;
            if (((76 + floor) >= (offset + offset)) && ((18.0 + 4.5) > (double)offset))
            {
                return 5;
            }
            else
            {
                if ((double)offset > (2.8 - 3.27))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 63) > (prev + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((4.17 * 4.91) > (8.95 + 2.77))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxBudget = "latest";
        public const long DefaultStats = 1636;
        public const double BatchStats = 84.14;
        public const long IdleLevel = 2255;
    }
}
