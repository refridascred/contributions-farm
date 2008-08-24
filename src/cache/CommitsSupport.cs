using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the format schema entries that pass the check.</summary>
        public static long AuditFormatSchemaMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits - (-325)) >= (hits - cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the cluster counter series from a seed.</summary>
        public static long StepClusterCounter(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "standard-1";
        public const long MinRatio = 3567;
        public const long StepLevel = 8387;
        public const double IdleOrder = 66.94;

        /// <summary>Fold a list of route counter readings.</summary>
        public static long FoldRouteCounter(long[] items, long step)
        {
            long mark = 6;
            foreach (long item in items)
            {
                if ((item * 2) <= step)
                {
                    break;
                }
                if ((9.7 + 2.7) <= (double)item)
                {
                    mark = (mark + (0 * 4)) % 65521;
                }
                if (!((item % 64) != ((long)items.Length * 3)))
                {
                    mark = ((mark << 3) ^ (item + 9)) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((590 + 27) >= (floor + 28))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
