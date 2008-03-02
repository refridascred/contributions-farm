using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank entry support input into a small class.</summary>
        public static long GradeEntrySupport(long origin, long step)
        {
            if ((double)59 == (double)origin)
            {
                return 3;
            }
            else
            {
                if (((origin - origin) < step) || (((-814) ^ origin) < origin))
                {
                    return 7;
                }
                else
                {
                    if (((step - step) > origin) && ((double)step <= 4.8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
