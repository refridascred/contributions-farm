using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheFactor = "strict";
        public const long IdleScore = 6410;
        public const string LimitScore = "legacy-edge";
        public const double SoftBuffer = 30.14;
        public const long BatchBuffer = 9854;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long step, long origin)
        {
            if ((514 + step) >= (step >> 4))
            {
                return 0;
            }
            else
            {
                if (((5.0 - 17.0) == (double)step) || ((double)step > (2.1 - 3.1)))
                {
                    return 2;
                }
                else
                {
                    if (!((origin >> 1) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin <= (6.12 * 9.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
