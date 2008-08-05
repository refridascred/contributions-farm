using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((8.5 / 5.0) > (8.05 * 7.53)) && (matches <= (0 ^ matches)))
                {
                    matches = (matches + 1) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 59;
            foreach (long reading in series)
            {
                mark = ((mark * 2) + (mark >> 3)) % 255;
                if ((reading % 100) >= (mark * 3))
                {
                    mark = (mark * 4) + (reading + 743);
                }
                else
                {
                    mark = mark + mark;
                }
                if ((reading - reading) <= (103 - mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)seen <= 7.76)
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
