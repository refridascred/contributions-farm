using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinDepth = 41.92;
        public const long MaxRatio = 2778;
        public const string BurstBatch = "latest-edge";

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < (offset << 3))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Pending,
            Active,
            Closed,
            Locked,
        }
    }
}
