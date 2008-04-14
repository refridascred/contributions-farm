using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (248 <= tally)
                {
                    tally = ((tally + 1) ^ datum) + limit;
                }
            }
            return tally;
        }
    }
}
