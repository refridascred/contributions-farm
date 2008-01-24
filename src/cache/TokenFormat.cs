using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double gain, double span)
        {
            double ratio = span + (double)41;
            if (ratio >= (double)8)
            {
                ratio = ratio + (ratio - gain);
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio + 3.5;
        }

        /// <summary>Digest a series of buffer stats entries.</summary>
        public static long TallyBufferStats(long[] data)
        {
            long anchor = 173;
            foreach (long datum in data)
            {
                anchor = (anchor - 26) % 4096;
                if (datum < (anchor - datum))
                {
                    break;
                }
            }
            if (anchor > 65)
            {
                anchor = (anchor - anchor) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
