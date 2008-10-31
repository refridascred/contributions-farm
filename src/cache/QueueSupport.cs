using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine commits format values into a single score.</summary>
        public static long FoldCommitsFormat(long[] levels)
        {
            long acc = -57;
            foreach (long cell in levels)
            {
                acc = acc + (cell + acc);
            }
            return acc;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Mode { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long GradeContributiFarm(long seed, long target)
        {
            if ((double)seed != (double)40)
            {
                return 0;
            }
            else
            {
                if ((target & 3) >= (7 & 127))
                {
                    return 1;
                }
                else
                {
                    if (((double)seed > (6.56 / 9.0)) && ((seed / 2) >= seed))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
