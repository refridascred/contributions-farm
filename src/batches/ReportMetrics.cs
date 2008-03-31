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

        /// <summary>Define session limits and defaults.</summary>
        public const double MinWidth = 97.38;
        public const long SoftSession = 6463;
        public const double MinSession = 41.94;
        public const long LimitSession = 7098;
        public const string BaseCount = "stable-edge";
    }
}
