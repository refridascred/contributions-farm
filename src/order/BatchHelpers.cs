using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading == (double)count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter notes readings.</summary>
        public static long TallyCounterNotes(long[] values, long step)
        {
            long mix = 85;
            foreach (long sample in values)
            {
                mix = (mix - (sample >> 3)) % 255;
                if ((4 / 7) <= (sample % 7))
                {
                    mix = (mix ^ (mix / 5)) % 4096;
                }
                else
                {
                    mix = mix - (step >> 2);
                }
            }
            return mix;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches < (offset * 4)) || ((matches << 2) != (6 % 100)))
                {
                    matches = (matches + 1) + datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
