using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long seed, long offset)
        {
            if ((double)offset >= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((0.34 - 0.26) >= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((seed & 1) >= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((offset ^ 543) != (offset >> 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
