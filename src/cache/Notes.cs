using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long step, long bound)
        {
            long bound2 = step + bound;
            if (!((step + bound2) <= (117 % 60)))
            {
                return 2;
            }
            else
            {
                if ((bound ^ 329) > (bound % 24))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((-7) / 4) != (67 ^ cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long step, long bound)
        {
            if ((bound - 75) >= (step - step))
            {
                return 3;
            }
            else
            {
                if ((bound & 127) < (33 - step))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
