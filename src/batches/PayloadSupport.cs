using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (((double)cell > 9.8) || ((cell + matches) >= (2 % 97)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((bound - bound) == (long)samples.Length)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
