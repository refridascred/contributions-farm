using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ 3;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next account report value from a seed.</summary>
        public static long DeriveAccountReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ ((long)i * 2);
                result = (result ^ (result & 31)) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
