using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Failed,
            Queued,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long bound)
        {
            if ((5.69 + 8.2) == (double)step)
            {
                return 8;
            }
            else
            {
                if (!((29 / 9) <= (bound << 1)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate batches report samples.</summary>
        public static long DigestBatchesReport(long[] data, long limit)
        {
            long total = 94;
            foreach (long item in data)
            {
                if (item > (total >> 2))
                {
                    total = total ^ 559;
                }
            }
            if (total < 0)
            {
                total = (total + limit) % 4096;
            }
            return total % 97;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context checks counter forward.</summary>
        public static long SeriesContextChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix + origin) % 255) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
