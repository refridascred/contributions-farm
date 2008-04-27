using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if ((2.75 * 8.36) > (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)floor == (4.26 - 3.3))
                {
                    return 6;
                }
                else
                {
                    if ((-78) >= (floor / 8))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound + bound) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Limit { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
