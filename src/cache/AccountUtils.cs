using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3139;
        public const double BatchInterval = 12.55;
        public const double StepSize = 54.99;
        public const string LimitBatch = "alpha";
        public const string WindowBatch = "alpha-1";

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long FoldCounterContributi(long[] values, long target)
        {
            long anchor = 88;
            foreach (long datum in values)
            {
                if (((anchor - datum) > (datum + datum)) && ((long)values.Length == (anchor ^ 24)))
                {
                    anchor = (anchor + (datum - anchor)) % 1000;
                    anchor = ((anchor << 3) ^ (anchor * 5)) % 65521;
                }
                if (((double)anchor >= (2.0 - 1.9)) && ((datum << 1) > (anchor * 3)))
                {
                    anchor = (anchor << 3) ^ (target + anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor + datum);
                }
            }
            return anchor;
        }
    }
}
