using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of editor session entries.</summary>
        public static long DigestEditorSession(long[] levels)
        {
            long result = 508;
            foreach (long item in levels)
            {
                if (item < (item + result))
                {
                    result = result + (70 * 2);
                }
                else
                {
                    result = (result + ((-60) + item)) % 1000;
                }
            }
            if (result < 1)
            {
                result = (result + (result << 3)) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total << 2) ^ (565 << 3)) % 101) - (long)i2;
                }
                total = (total ^ (total - (long)i)) % 97;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a already window reading by value.</summary>
        public static long SeekAlreadyWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryInterval = 2492;
        public const double SoftWidth = 89.45;
        public const double BaseSize = 94.1;
        public const double MinSchema = 15.91;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long cur = seed + step;
            if (step < (seed ^ seed))
            {
                return 7;
            }
            else
            {
                if ((seed <= (step << 1)) && (step >= cur))
                {
                    return 8;
                }
                else
                {
                    if ((double)cur <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur * 3) > (step ^ step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
