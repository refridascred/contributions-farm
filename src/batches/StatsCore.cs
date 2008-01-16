using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Done,
            Locked,
            Stale,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1.83 * 6.95) < (double)matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate channel contributi readings against a bound.</summary>
        public static bool CheckChannelContributiBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double scale, double bias)
        {
            double ratio = 0.19;
            return ((ratio + (3.0 / 2.0)) + scale) + bias;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Active,
            Closed,
            Pending,
            Stale,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            New,
            Dropped,
        }
    }
}
