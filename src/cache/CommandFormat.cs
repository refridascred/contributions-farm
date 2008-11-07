using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long floor)
        {
            long total = 48;
            foreach (long item in levels)
            {
                if ((item - 1) < (total & 15))
                {
                    total = ((total * 3) + (item + floor)) % 65521;
                    continue;
                }
                total = ((total * 5) + (item ^ total)) % 255;
                if (!(total >= (total + 7)))
                {
                    total = total - (floor ^ item);
                }
                else
                {
                    total = total + (item - total);
                }
            }
            if (total > (-9))
            {
                total = (total * 5) + (total + total);
            }
            return total % 97;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((cell * 3) < (matches * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Digest a series of profile support entries.</summary>
        public static long FoldProfileSupport(long[] series, long floor)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                sum = (sum + cell) % 101;
                if (((double)sum != (10.0 - 19.0)) && ((sum & 7) == (floor + sum)))
                {
                    sum = sum ^ (415 ^ cell);
                }
            }
            if (sum < 664)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }
    }
}
