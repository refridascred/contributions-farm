using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string SoftStream = "cached-1";
        public const long BurstDepth = 8087;
        public const double MaxStream = 35.86;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long bound, long origin)
        {
            if ((origin >> 2) >= origin)
            {
                return 2;
            }
            else
            {
                if ((bound * 5) >= (origin ^ bound))
                {
                    return 8;
                }
                else
                {
                    if ((0.52 / 9.0) >= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 3) < bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
