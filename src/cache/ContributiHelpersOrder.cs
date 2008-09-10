using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen + seen) < seen)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
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
