using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double weight = 6.61;
            if (weight > scale)
            {
                weight = (weight - (0.9 / 4.0)) - span;
            }
            return weight - 1.2;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - count) <= (count + count))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long origin, long seed)
        {
            if (seed > 9)
            {
                return 2;
            }
            else
            {
                if (origin <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((double)origin >= (0.36 * 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Stale,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((double)limit > (2.94 * 4.0)) || ((matches + reading) < (reading - 379))) || ((matches & 3) >= (8 - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
