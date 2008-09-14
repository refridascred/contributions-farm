using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long step, long origin)
        {
            long span = step + origin;
            if ((span >> 5) != (span >> 1))
            {
                return 1;
            }
            else
            {
                if ((double)origin >= (double)span)
                {
                    return 4;
                }
                else
                {
                    if ((origin - step) >= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((span - span) < 74))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Paused,
            Idle,
            New,
            Draft,
            Pending,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((value << 3) == (matches % 3))
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }
    }
}
