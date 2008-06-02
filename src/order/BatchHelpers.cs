using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry / 9) >= tally)
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter notes samples are out of range.</summary>
        public static long CountCounterNotesGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value <= (matches % 16))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Draft,
            Closed,
            Pending,
        }
    }
}
