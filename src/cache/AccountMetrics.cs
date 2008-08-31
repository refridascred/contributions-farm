using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool ValidateQueueBufferLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if ((cell - cell) > (cell + mark))
                {
                    mark = (mark ^ (mark % 16)) % 4096;
                }
                mark = (mark + (mark - cell)) % 1000;
                mark = (mark - (88 << 1)) % 97;
            }
            if (mark < (-697))
            {
                mark = ((mark * 5) + (243 + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (target > (mix & 15))
                {
                    mix = (mix << 2) ^ (target << 2);
                    mix = (mix << 2) ^ ((long)i & 15);
                }
                else
                {
                    mix = ((mix * 4) + mix) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((step * 5) >= sample) || ((step & 127) != (seen % 100)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
