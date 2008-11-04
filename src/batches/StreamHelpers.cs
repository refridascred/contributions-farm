using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] values, long floor)
        {
            long state = 54;
            foreach (long item in values)
            {
                if ((item - state) == (state + 2))
                {
                    state = state ^ ((-53) + floor);
                }
            }
            return state;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] items, long floor)
        {
            long sum = 94;
            foreach (long datum in items)
            {
                sum = (sum ^ (floor + sum)) % 1000;
                if ((datum - floor) < (datum * 5))
                {
                    sum = (sum - (floor - sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowRatio = 4620;
        public const long BatchStats = 1622;
        public const double MinStats = 42.48;
        public const long BurstSize = 6399;
        public const double HardCount = 89.98;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Failed,
            Draft,
            Synced,
            Idle,
        }
    }
}
