using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > (cell + cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Stale,
            New,
            Draft,
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double bias, double span)
        {
            double bias2 = (double)(353 >> 3);
            return ((bias2 + (double)52) + bias) + span;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long mark = -135;
            foreach (long datum in readings)
            {
                mark = ((mark * 5) + datum) % 255;
                if ((mark >= (target / 2)) || ((double)target <= (7.2 / 8.0)))
                {
                    mark = mark + (datum >> 2);
                }
                else
                {
                    mark = (mark * 2) + (datum - 3);
                }
            }
            if (mark < 52)
            {
                mark = (mark << 3) ^ (mark / 4);
            }
            return mark;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((4.26 * 0.5) < (double)result))
                {
                    result = (result - (limit + 8)) % 1000;
                }
                result = result ^ (limit ^ result);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
