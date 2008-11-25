using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Stamp { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate session commits samples.</summary>
        public static long CombineSessionCommits(long[] items)
        {
            long acc = -159;
            foreach (long cell in items)
            {
                if (!(948 > cell))
                {
                    acc = ((acc << 2) ^ (cell >> 5)) % 97;
                }
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc << 3) ^ (acc - (long)i);
                }
                if (((acc - acc) > cell) && ((5.2 * 3.4) > (double)acc))
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc % 1000;
        }
    }
}
