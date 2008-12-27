using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank buffer contributi input into a small class.</summary>
        public static long GradeBufferContributi(long floor, long origin)
        {
            long prev = floor ^ origin;
            if ((origin + prev) < (origin - floor))
            {
                return 3;
            }
            else
            {
                if (((floor + prev) <= (origin % 24)) && ((origin << 1) > origin))
                {
                    return 1;
                }
                else
                {
                    if ((floor - 61) <= (origin - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Idle,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Owner { get; set; }
            public bool Level { get; set; }
        }
    }
}
