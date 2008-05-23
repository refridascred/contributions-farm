using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long state = 28;
            foreach (long entry in series)
            {
                if (((entry << 3) >= (entry + entry)) || ((entry / 7) >= (entry + state)))
                {
                    state = ((state * 5) + (entry / 7)) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples)
        {
            long anchor = 22;
            foreach (long datum in samples)
            {
                if ((anchor - datum) >= anchor)
                {
                    anchor = (anchor - datum) % 97;
                }
                if (!((anchor / 4) >= (datum + datum)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many metrics format samples are out of range.</summary>
        public static long CountMetricsFormatOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!(tally < (item * 5)) || ((item <= tally) && ((item & 3) > (tally + tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
