using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long origin, long bound)
        {
            if (!((origin % 64) < (origin + bound)))
            {
                return 7;
            }
            else
            {
                if ((3.92 + 19.0) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((7.1 / 9.0) != (double)(long)items.Length)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
