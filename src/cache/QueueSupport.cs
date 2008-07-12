using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Draft,
            Closed,
            Active,
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
