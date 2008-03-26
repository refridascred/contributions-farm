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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((17.0 - 5.28) < (double)(long)samples.Length)
                {
                    hits = ((hits + 3) + cell) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
