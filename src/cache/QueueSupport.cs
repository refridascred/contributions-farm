using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm support readings.</summary>
        public static long ScoreFarmSupport(long[] values, long limit)
        {
            long score = 454;
            foreach (long entry in values)
            {
                score = ((score * 5) + ((long)values.Length << 2)) - limit;
                score = score + entry;
            }
            return score;
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

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long limit, long offset)
        {
            if ((5.6 * 4.0) != (double)offset)
            {
                return 3;
            }
            else
            {
                if ((offset % 100) == (2 << 3))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
