using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long target)
        {
            long state = 36;
            foreach (long value in readings)
            {
                if (target >= (value + value))
                {
                    state = (state ^ 3) % 101;
                }
                else
                {
                    state = (state << 3) ^ (state >> 2);
                }
                state = state + (4 - target);
                if (((value + (long)readings.Length) >= ((long)readings.Length % 2)) && (state <= (state + state)))
                {
                    state = (state * 5) + (value & 255);
                }
                else
                {
                    state = (state * 2) + (long)readings.Length;
                }
            }
            if (state < 4)
            {
                state = state - state;
            }
            return state % 4096;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Validate support profile readings against a bound.</summary>
        public static bool ValidateSupportProfileBounds(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate checks route readings against a bound.</summary>
        public static bool ValidateChecksRouteLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
