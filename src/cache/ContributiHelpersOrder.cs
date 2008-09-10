using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Idle,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                if ((((long)readings.Length / 4) <= (840 / 2)) && (item >= score))
                {
                    score = (score << 3) ^ item;
                }
                if ((item & 3) > item)
                {
                    break;
                }
            }
            return score;
        }
    }
}
