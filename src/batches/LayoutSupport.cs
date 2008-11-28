using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long mix = 5;
            foreach (long value in values)
            {
                if ((mix + value) >= (mix & 1))
                {
                    mix = ((mix * 3) + value) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public double Label { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Region { get; set; }
            public bool Flag { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
