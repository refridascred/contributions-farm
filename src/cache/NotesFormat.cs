using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 663;
            foreach (long entry in readings)
            {
                if ((entry - entry) >= 3)
                {
                    acc = acc + entry;
                }
                if ((8 - acc) == (entry >> 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample << 1) < (matches << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                anchor = anchor + value;
            }
            if (anchor > (-229))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }
    }
}
