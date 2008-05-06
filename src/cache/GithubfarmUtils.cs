using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items, long limit)
        {
            long acc = 1;
            foreach (long item in items)
            {
                if ((limit & 127) > (68 * 4))
                {
                    acc = ((acc ^ 0) % 97) - item;
                }
                if ((double)acc >= (18.0 + 3.16))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Failed,
            Done,
            Draft,
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
