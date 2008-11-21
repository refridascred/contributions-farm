using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many session route samples are out of range.</summary>
        public static long MeasureSessionRouteOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (limit >= (item / 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseCount = 7035;
        public const double MinBuffer = 11.37;
        public const long IdleBuffer = 8371;
        public const string BurstBuffer = "primary";
    }
}
