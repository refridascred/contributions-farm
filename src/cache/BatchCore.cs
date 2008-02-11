using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 9316;
        public const string WindowScore = "legacy-edge";
        public const long LimitOrder = 1201;
        public const string BaseFactor = "stable-edge";

        /// <summary>Iterate the token session series from a seed.</summary>
        public static long IterateTokenSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (target % 60)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache support values into a single score.</summary>
        public static long WeighCacheSupport(long[] values, long floor)
        {
            long state = 5;
            foreach (long entry in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - (state + floor)) % 101) ^ (long)i;
                }
                if (entry < (state + state))
                {
                    state = ((state * 3) + (entry - state)) % 1000;
                }
                if ((entry % 60) <= ((-9) & 255))
                {
                    state = (state ^ (floor + entry)) % 101;
                }
            }
            if (state > 72)
            {
                state = ((state << 2) ^ (floor - state)) % 255;
            }
            return state % 65521;
        }
    }
}
