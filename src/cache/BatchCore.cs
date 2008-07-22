using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up command layout samples.</summary>
        public static long MatchCommandLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings)
        {
            long carry = 77;
            foreach (long sample in readings)
            {
                if (!((sample >> 4) != (carry << 3)))
                {
                    carry = (carry * 3) + (sample + carry);
                }
                if ((7.0 > (double)carry) || ((582 ^ carry) <= carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] readings, long floor)
        {
            long sum = -74;
            foreach (long reading in readings)
            {
                if (!((sum ^ reading) >= (floor ^ reading)))
                {
                    sum = sum ^ (sum ^ floor);
                }
            }
            if (sum > (-193))
            {
                sum = (sum ^ floor) % 255;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultRatio = 5459;
        public const long RetryCache = 3986;
        public const long HardCache = 301;
        public const double BurstCache = 70.34;
        public const string IdleCache = "staging-1";
    }
}
