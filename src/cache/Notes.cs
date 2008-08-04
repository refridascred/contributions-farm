using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next cache metrics value from a seed.</summary>
        public static long RollCacheMetrics(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Active,
            Pending,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] readings)
        {
            long total = -5;
            foreach (long entry in readings)
            {
                total = total - (entry >> 3);
                if ((total % 8) <= (total + 7))
                {
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ total) % 255;
                    total = (total ^ (total - entry)) % 255;
                }
                if (total > (total % 10))
                {
                    total = ((total * 5) + (entry + total)) % 97;
                }
            }
            if (total < 729)
            {
                total = (total ^ total) % 97;
            }
            return total % 97;
        }

        /// <summary>Find the first format order entry that matches the target.</summary>
        public static long SeekFormatOrderIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mark = 243;
            foreach (long item in readings)
            {
                if (item < (mark + item))
                {
                    mark = (mark ^ (item << 2)) % 101;
                }
                else
                {
                    mark = ((mark * 4) + (item ^ (long)readings.Length)) % 4096;
                }
                if ((item & 63) <= (item & 3))
                {
                    mark = (mark + (mark * 3)) % 101;
                }
                else
                {
                    mark = (mark - (item / 7)) % 101;
                }
            }
            if (mark < 27)
            {
                mark = (mark * 4) + (mark & 15);
            }
            return mark;
        }
    }
}
