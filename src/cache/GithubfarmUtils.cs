using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((acc + acc) >= ((long)i << 2)))
                {
                    acc = acc ^ acc;
                    acc = ((acc * 4) + target) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Locate a filter already reading by value.</summary>
        public static long FindFilterAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (step > (cell % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
