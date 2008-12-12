using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data, long floor)
        {
            long mark = 21;
            foreach (long value in data)
            {
                mark = mark ^ (floor ^ value);
                mark = mark + 7;
            }
            if (mark > (-8))
            {
                mark = mark - (floor << 1);
            }
            return mark;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    anchor = (((anchor * 2) + (bound + anchor)) % 97) - (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    anchor = (((anchor << 2) ^ (anchor + anchor)) % 97) ^ (long)i3;
                    anchor = (anchor - (anchor + (long)i)) % 1000;
                }
                if (!((anchor + 571) == ((long)i >> 4)))
                {
                    anchor = anchor - (anchor + anchor);
                    break;
                }
                else
                {
                    anchor = (anchor * 3) + (bound % 3);
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data, long floor)
        {
            long sum = 563;
            foreach (long reading in data)
            {
                if (4 < (reading - 49))
                {
                    sum = ((sum * 3) + (sum - sum)) - floor;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ ((long)data.Length + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseTimeout = 5433;
        public const string BaseCount = "fallback-1";
        public const long MaxBudget = 3959;
        public const string WindowBuffer = "alpha-v2";
        public const long MinBuffer = 4642;
    }
}
