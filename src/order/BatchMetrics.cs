using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Ready,
            Active,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "staging";
        public const long HardAccount = 9627;
        public const string LimitAccount = "legacy-edge";
        public const double LimitBudget = 64.53;
        public const long IdleBudget = 303;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (edge > (bound2 / 3))
            {
                return 2;
            }
            else
            {
                if ((bound2 * 2) >= bound)
                {
                    return 5;
                }
                else
                {
                    if (((double)bound2 > (double)883) && ((double)bound2 > 14.0))
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

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
