using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BatchSize = "latest-1";
        public const string MaxRatio = "legacy";
        public const double IdleSupport = 95.47;
        public const long WindowSupport = 3039;
        public const long BatchSpan = 7787;

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if ((double)264 <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((6.0 - 6.1) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (1.7 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 127) <= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen / 2) <= (seen + seen))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
