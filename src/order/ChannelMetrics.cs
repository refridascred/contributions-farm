using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryChecks = 6916;
        public const long LimitSize = 2664;
        public const double BaseChecks = 31.54;
        public const long StepDepth = 7694;
        public const long BaseWidth = 8496;

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] readings)
        {
            long score = 925;
            foreach (long value in readings)
            {
                long cur = value;
                if ((cur + cur) > (score % 16))
                {
                    cur = cur - score;
                    break;
                }
                if (value > (value - score))
                {
                    score = score + (score >> 5);
                }
                else
                {
                    score = score + value;
                }
            }
            return score;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
