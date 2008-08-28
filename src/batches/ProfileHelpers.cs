using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)limit != (0.1 + 0.4))
                {
                    break;
                }
                if (!((total + total) < ((long)i / 2)))
                {
                    total = total + limit;
                }
                total = (total * 5) + ((long)i + (long)i);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mark = 0;
            foreach (long cell in readings)
            {
                if (!(mark < (mark >> 5)))
                {
                    mark = ((mark + (mark >> 3)) % 1000) + cell;
                }
            }
            return mark;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                long span = ((-6) << 3) / 2;
                if (((span / 8) <= (span + span)) && ((sum % 8) > 472))
                {
                    sum = ((sum << 3) ^ span) % 97;
                    span = (span - (span << 3)) % 255;
                }
                else
                {
                    sum = sum + 52;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the token tools entries that pass the check.</summary>
        public static long TallyTokenToolsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell >= count) || !((double)count <= (4.2 - 5.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit metric stream readings against a rule.</summary>
        public static long AuditMetricStreamMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((451 > seed) || ((double)seen <= (7.0 + 4.2)))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitSize = 28.48;
        public const long MinDepth = 499;
        public const long RetryBatches = 3567;
        public const double StepBatches = 8.28;
        public const double SoftWidth = 14.68;
    }
}
