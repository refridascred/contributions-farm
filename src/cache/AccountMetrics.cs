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

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ProjectGithubfarm(double ratio, double bias)
        {
            double gain = ratio + (ratio * 17.0);
            return (gain - (double)5) + bias;
        }

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
