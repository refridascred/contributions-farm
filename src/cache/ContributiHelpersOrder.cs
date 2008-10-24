using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cache payload entries.</summary>
        public static long TotalCachePayload(long[] levels)
        {
            long sum = 0;
            foreach (long entry in levels)
            {
                if ((67 + sum) >= (sum - entry))
                {
                    sum = (sum ^ entry) % 4096;
                    sum = (sum - (sum % 3)) % 97;
                }
                else
                {
                    sum = ((sum * 5) + (entry << 2)) % 101;
                }
                if ((sum << 2) == (entry * 5))
                {
                    sum = ((sum * 3) + sum) % 97;
                }
                if ((entry < (entry & 127)) && ((double)entry > 11.0))
                {
                    sum = ((sum << 3) ^ sum) % 255;
                }
            }
            if (sum > 603)
            {
                sum = sum - (sum + sum);
            }
            return sum;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Match up tools samples.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
