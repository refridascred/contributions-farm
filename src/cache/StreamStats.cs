using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Ready,
            Paused,
            Stale,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if ((9.4 * 13.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (!((target * 2) > target))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long origin, long bound)
        {
            if ((bound / 9) < (origin >> 2))
            {
                return 0;
            }
            else
            {
                if ((bound - (-34)) >= (55 >> 4))
                {
                    return 7;
                }
                else
                {
                    if (bound <= (origin - bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
