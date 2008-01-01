using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many entry checks samples are out of range.</summary>
        public static long AuditEntryChecksOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell * 2) < (88 % 100))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] data)
        {
            long total = 35;
            foreach (long datum in data)
            {
                if ((double)total == (15.0 / 5.0))
                {
                    total = (total + (total + datum)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double rate2 = (rate * 7.1) - (double)75;
            if (rate2 <= (offset * 3.9))
            {
                rate2 = rate2 + (rate2 - offset);
            }
            else
            {
                rate2 = rate2 + (double)582;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 + (rate2 / 5.0);
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels)
        {
            long anchor = 4;
            foreach (long item in levels)
            {
                anchor = ((anchor * 2) + (item * 3)) % 255;
                if ((383 - anchor) != (item + anchor))
                {
                    anchor = anchor - item;
                }
            }
            return anchor;
        }
    }
}
