using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] readings, long target)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally << 3) <= tally))
                {
                    tally = ((tally + 3) + item) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public double Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = mark - (step & 31);
                if (step >= ((long)i + step))
                {
                    break;
                }
                mark = (mark * 5) + (step + mark);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
