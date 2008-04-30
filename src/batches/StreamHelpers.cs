using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long GradeRecord(long step, long floor)
        {
            if (464 >= (step ^ floor))
            {
                return 2;
            }
            else
            {
                if (((-13) & 3) <= (step % 5))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step ^ 534) < (floor / 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate token support readings against a bound.</summary>
        public static bool ValidateTokenSupportRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchBudget = 75.74;
        public const long SoftMetrics = 3626;
        public const long MaxMetrics = 7856;
    }
}
