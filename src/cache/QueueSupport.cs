using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((8.47 - 7.5) > (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double span)
        {
            double load = span + span;
            if (load <= (double)1)
            {
                load = load + load;
            }
            else
            {
                load = load + (span - rate);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (span - load)) + (double)(long)i;
            }
            return load + rate;
        }
    }
}
