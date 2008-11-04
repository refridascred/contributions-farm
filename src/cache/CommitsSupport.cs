using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every account cluster entry stays within the limit.</summary>
        public static bool CheckAccountClusterRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Draft,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                if (6.0 <= (double)reading)
                {
                    acc = acc ^ (822 - (long)samples.Length);
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ reading) % 255;
                }
                if (acc > (reading + acc))
                {
                    acc = ((acc << 3) ^ (reading + 702)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 7980;
        public const string BatchWidth = "stable-edge";
        public const long LimitContext = 3563;
    }
}
