using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long target, long bound)
        {
            long cur = target ^ bound;
            if ((55 > (cur ^ target)) && ((target + cur) < target))
            {
                return 7;
            }
            else
            {
                if ((target - cur) >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((cur ^ target) != (95 + (-66)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
