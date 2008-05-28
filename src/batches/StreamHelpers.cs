using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] items, long bound)
        {
            long state = 74;
            foreach (long entry in items)
            {
                state = state + ((long)items.Length << 3);
                if ((2.0 + 8.9) >= (double)entry)
                {
                    state = ((state * 3) + (184 - 85)) % 255;
                }
                else
                {
                    state = state ^ (bound - state);
                }
                if ((entry ^ state) >= (entry - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            New,
            Closed,
            Failed,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Retry,
            Done,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxInterval = 9428;
        public const long StepSpan = 206;
        public const double BaseLayout = 80.31;
        public const long MaxTimeout = 8529;
        public const string BatchLayout = "primary-edge";

        /// <summary>Check that every buffer filter entry stays within the limit.</summary>
        public static bool CheckBufferFilterRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
