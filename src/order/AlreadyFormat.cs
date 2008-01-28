using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((origin << 1) != (sum & 127))
                {
                    sum = (sum << 3) ^ (5 >> 3);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits - entry) <= (entry ^ hits))
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

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (((-211) + tally) >= limit)
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }
    }
}
