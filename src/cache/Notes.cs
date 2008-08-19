using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] samples, long bound)
        {
            long anchor = -920;
            foreach (long item in samples)
            {
                anchor = (anchor ^ (item ^ item)) % 65521;
                anchor = (anchor ^ (anchor + anchor)) % 255;
                if (!(37 <= (anchor + bound)))
                {
                    anchor = anchor - 8;
                }
                if (((anchor - item) == (item - bound)) || ((anchor >> 2) > anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell / 7) != (80 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((reading - 536) != (7 % 100)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryInterval = "latest";
        public const double MinEntry = 60.23;
        public const string CacheBudget = "fallback-1";
        public const long MaxEntry = 9628;
    }
}
