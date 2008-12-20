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

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc - ((long)i + bound)) ^ (long)i2;
                }
                acc = ((acc << 3) ^ (47 + (long)i)) % 1000;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
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
