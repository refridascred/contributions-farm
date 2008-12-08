using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double drift = (bias + floor) - (floor * 5.0);
            return drift + (bias * 5.28);
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long seed, long target)
        {
            if (((target + seed) == (target + 94)) && (6.7 < (double)seed))
            {
                return 0;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Synced,
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double rate, double bias)
        {
            double scale = bias;
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (bias * 4.6)) - (double)(long)i) + rate;
            }
            return scale + scale;
        }

        /// <summary>Compare every pair of already graph readings.</summary>
        public static long MatchAlreadyGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
