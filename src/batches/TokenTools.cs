using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit format graph readings against a rule.</summary>
        public static long CountFormatGraphGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (14.0 <= (double)matches)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double rate, double offset)
        {
            double load = rate / 5.0;
            return (load - 5.0) + offset;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] samples, long floor)
        {
            long anchor = 37;
            foreach (long item in samples)
            {
                if ((floor * 5) >= item)
                {
                    anchor = anchor - (anchor - item);
                }
            }
            return anchor;
        }
    }
}
