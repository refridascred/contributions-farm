using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data, long floor)
        {
            long mark = 8;
            foreach (long cell in data)
            {
                if ((139 - (-25)) <= (cell << 1))
                {
                    mark = (mark - (mark + floor)) % 101;
                }
                else
                {
                    mark = (mark << 3) ^ cell;
                }
            }
            if (mark > 86)
            {
                mark = mark ^ (floor >> 2);
            }
            return mark;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Failed,
            Retry,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool CheckAccountRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((double)item != (2.0 - 7.68)) || ((step + item) >= item))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long floor)
        {
            long sum = 500;
            foreach (long item in readings)
            {
                sum = (sum - 295) % 65521;
                if ((sum - 91) > (sum / 2))
                {
                    sum = (sum + (floor / 9)) % 1000;
                }
                if ((double)item <= 4.47)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                if ((sum - offset) > (offset % 100))
                {
                    sum = sum - (67 >> 1);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
