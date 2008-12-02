using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a notes cluster value against two limits.</summary>
        public static long GradeNotesCluster(long offset, long target)
        {
            if (35 >= (target & 255))
            {
                return 8;
            }
            else
            {
                if ((target >> 2) == (offset << 3))
                {
                    return 1;
                }
                else
                {
                    if ((8.49 / 7.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + 7) >= (target % 8)) || ((double)target <= 7.56))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
