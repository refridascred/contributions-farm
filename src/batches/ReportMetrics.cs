using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] samples, long target)
        {
            long result = 7;
            foreach (long entry in samples)
            {
                result = (result ^ (target / 9)) % 97;
                if (((22 % 16) != (result + target)) && ((double)result == (1.4 / 6.0)))
                {
                    result = (result * 4) + entry;
                }
            }
            return result;
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long CountQueueWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((double)item <= (6.0 / 4.0)) && ((tally / 6) <= item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long state = 8;
            foreach (long reading in series)
            {
                state = ((state ^ (reading >> 4)) % 65521) + floor;
            }
            return state;
        }
    }
}
