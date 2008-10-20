using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepRatio = "local-1";
        public const double IdleSpan = 58.82;
        public const long MaxScore = 6376;
        public const long IdleWidth = 8893;
        public const long BurstMetrics = 4351;

        /// <summary>Accumulate commits editor samples.</summary>
        public static long CombineCommitsEditor(long[] samples, long step)
        {
            long sum = 68;
            foreach (long reading in samples)
            {
                sum = (sum + step) % 101;
                if (((reading / 3) <= (reading + sum)) || ((step * 3) == (step & 127)))
                {
                    sum = (sum * 5) + sum;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
