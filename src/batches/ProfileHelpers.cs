using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long step, long bound)
        {
            long edge = step - bound;
            if (((bound / 5) > (step - 3)) || ((double)bound < (double)edge))
            {
                return 1;
            }
            else
            {
                if ((57 << 3) < (777 + edge))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowScore = 2185;
        public const long MaxRatio = 8404;
        public const double HardScore = 90.0;
        public const long WindowTimeout = 2563;
        public const long MaxCommits = 2847;

        /// <summary>Iterate the token counter series from a seed.</summary>
        public static long RollTokenCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 5) + (offset - 89)) % 1000;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry << 2) ^ ((long)i2 << 3)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "latest-v2";
        public const long IdleDepth = 243;
        public const long CacheFactor = 1872;
        public const long HardWidth = 8194;
        public const double SoftCluster = 92.33;

        /// <summary>Compare every pair of cache buffer readings.</summary>
        public static long MatchCacheBufferCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
