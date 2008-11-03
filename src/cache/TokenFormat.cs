using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Paused,
            Pending,
            Idle,
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long score = seed;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 3) + seed) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] levels, long origin)
        {
            long result = 944;
            foreach (long datum in levels)
            {
                if ((origin - datum) >= (result / 7))
                {
                    result = result + (12 + 530);
                }
                else
                {
                    result = result - origin;
                }
                if (((0.69 / 4.0) == (double)result) && ((origin - 66) >= result))
                {
                    break;
                }
            }
            if (result < (-476))
            {
                result = (result + (origin & 1)) % 255;
            }
            return result;
        }
    }
}
