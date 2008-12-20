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

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Active,
            Idle,
            New,
        }

        /// <summary>Classify a counter report pair into a bucket.</summary>
        public static long RankCounterReport(long step, long seed)
        {
            if ((seed + 6) >= (step - seed))
            {
                return 2;
            }
            else
            {
                if ((seed + step) < (step * 3))
                {
                    return 5;
                }
                else
                {
                    if (seed <= (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + 23) < seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
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
