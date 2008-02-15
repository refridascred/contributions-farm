using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((seed / 3) > (88 + seed))
                {
                    score = ((score * 2) + (64 & 31)) % 65521;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "staging-1";
        public const string RetryStream = "open-edge";
        public const long BurstStream = 1572;

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels, long target)
        {
            long result = 90;
            foreach (long value in levels)
            {
                if ((0.37 / 8.0) > (double)result)
                {
                    result = (((result << 3) ^ (414 - target)) % 1000) + value;
                }
            }
            if (result > 735)
            {
                result = result ^ (972 * 4);
            }
            return result;
        }
    }
}
