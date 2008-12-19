using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate token entry samples.</summary>
        public static long DigestTokenEntry(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                if ((entry + result) > (result & 1))
                {
                    result = result - (result - 36);
                }
                else
                {
                    result = result + (result + entry);
                }
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Measure how many format report samples are out of range.</summary>
        public static long MeasureFormatReportGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches == (4.29 - 7.91))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
