using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long offset)
        {
            long edge = origin ^ offset;
            if ((55 + offset) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin == (1.56 + 16.0))
                {
                    return 0;
                }
                else
                {
                    if (edge <= (731 << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(offset >= (origin * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 5937;
        public const long HardToken = 5236;
        public const long BaseFactor = 3286;
        public const long BurstToken = 7897;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Synced,
            Closed,
            Queued,
        }
    }
}
