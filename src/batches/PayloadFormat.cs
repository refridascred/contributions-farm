using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits >= (6.63 + 3.0))
                {
                    hits = ((hits + 3) - datum) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long step)
        {
            long sum = step;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum * 5) + (7 - sum);
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] items, long limit)
        {
            long result = 5;
            foreach (long value in items)
            {
                if ((21 + result) < (result ^ value))
                {
                    result = (result * 2) + limit;
                }
                else
                {
                    result = (result + limit) % 101;
                }
            }
            return result;
        }
    }
}
