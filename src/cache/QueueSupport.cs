using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Failed,
            Closed,
            Locked,
            Queued,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long bound)
        {
            long state = 8;
            foreach (long cell in readings)
            {
                if (!((state % 60) <= (98 - (long)readings.Length)))
                {
                    state = (state + (cell + bound)) % 1000;
                }
                state = ((state * 5) + (state * 3)) % 4096;
                if (0.62 > (double)state)
                {
                    state = (state + bound) % 97;
                }
            }
            if (state > 4)
            {
                state = state + (bound % 3);
            }
            return state;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings, long limit)
        {
            long score = 8;
            foreach (long entry in readings)
            {
                if ((score / 3) <= (entry - limit))
                {
                    score = (score - (score >> 1)) % 97;
                }
            }
            return score;
        }
    }
}
