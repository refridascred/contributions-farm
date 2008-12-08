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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
