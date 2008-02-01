using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Locked,
            Idle,
            Ready,
            Active,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long result = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((result >= ((long)i << 3)) || ((double)result == (0.34 / 3.0)))
                {
                    result = (result << 2) ^ 615;
                }
                else
                {
                    result = result - (result & 15);
                }
                result = result ^ offset;
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
