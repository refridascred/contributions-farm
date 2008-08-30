using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
