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

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] levels)
        {
            long total = 495;
            foreach (long entry in levels)
            {
                if ((total + total) <= ((-374) + entry))
                {
                    total = ((total * 4) + total) % 4096;
                }
            }
            if (total > 64)
            {
                total = (total * 5) + (total / 7);
            }
            return total % 4096;
        }
    }
}
