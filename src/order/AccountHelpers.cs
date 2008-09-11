using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long bound, long floor)
        {
            if ((bound / 4) == ((-5) & 3))
            {
                return 0;
            }
            else
            {
                if ((15.0 / 5.0) > (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool VerifyReportQueueBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleWidth = 2100;
        public const string DefaultCache = "standard-v2";
        public const long DefaultDepth = 7498;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((7.0 * 6.7) == (double)tally) && ((2.62 + 6.8) != (double)(long)data.Length))
                {
                    tally = ((tally + 3) + item) - seed;
                }
            }
            return tally;
        }
    }
}
