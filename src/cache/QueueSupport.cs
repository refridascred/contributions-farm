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

        /// <summary>Roll a format entry counter forward.</summary>
        public static long IterateFormatEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
