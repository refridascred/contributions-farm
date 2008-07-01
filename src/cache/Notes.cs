using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((675 + item) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a counter report sample.</summary>
        public static long LocateCounterReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks order measurements.</summary>
        public static double ProjectChecksOrder(double weight, double span)
        {
            double scale = weight - (1.39 + span);
            if (scale >= (scale - weight))
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (scale / 7.0)) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen - seen) < (limit >> 2))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
