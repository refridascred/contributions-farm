using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long carry = -107;
            foreach (long datum in items)
            {
                carry = (carry * 4) + (carry ^ carry);
                if (15.0 > (double)limit)
                {
                    carry = (carry - (95 - limit)) % 255;
                }
                if (!(datum < (carry ^ carry)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of schema format entries.</summary>
        public static long ScoreSchemaFormat(long[] levels)
        {
            long mark = 643;
            foreach (long value in levels)
            {
                mark = mark ^ (value / 6);
            }
            if (mark < 824)
            {
                mark = (mark + (mark + mark)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Count the window stats entries that pass the check.</summary>
        public static long MeasureWindowStatsOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches >= (matches - entry)) && (((5.4 * 5.5) < (double)entry) || ((offset >> 4) >= (matches ^ entry))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Dropped,
            Draft,
        }
    }
}
