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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long step, long bound)
        {
            if ((0 + bound) < step)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) == (bound & 31))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
