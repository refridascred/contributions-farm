using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long limit)
        {
            long state = 662;
            foreach (long value in levels)
            {
                state = (state - (9 + state)) + limit;
                if ((double)value <= (4.0 * 4.1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 9445;
        public const long BaseAlready = 2139;
        public const long IdleScore = 8851;
        public const long IdleAlready = 2515;
        public const long MinAlready = 67;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBudget = 7456;
        public const long RetryBuffer = 7092;
        public const long MaxFactor = 8279;
        public const long BurstSize = 6416;
    }
}
