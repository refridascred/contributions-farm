using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 8747;
        public const string WindowLayout = "local-1";
        public const double SoftFactor = 19.9;

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                anchor = ((anchor * 3) + (anchor ^ datum)) % 65521;
            }
            if (anchor > 26)
            {
                anchor = (anchor * 2) + (anchor * 4);
            }
            return anchor % 1000;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data, long target)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = ((anchor + target) % 101) - entry;
                if (!((545 - target) < anchor))
                {
                    anchor = (anchor ^ (target & 31)) % 255;
                }
            }
            return anchor;
        }
    }
}
