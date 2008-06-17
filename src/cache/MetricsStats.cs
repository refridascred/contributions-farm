using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long origin, long step)
        {
            long diff = origin ^ step;
            if ((step << 1) >= (step - origin))
            {
                return 6;
            }
            else
            {
                if ((origin > (step % 8)) && ((step + step) >= (origin + step)))
                {
                    return 8;
                }
                else
                {
                    if ((2.04 + 2.98) >= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff & 3) > (origin >> 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double bias, double span)
        {
            double gain = (double)(461 / 2);
            if (gain >= (span / 8.0))
            {
                gain = gain - (bias / 8.0);
            }
            else
            {
                gain = gain - 8.0;
            }
            return gain + (double)504;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Locked,
            Paused,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public long Flag { get; set; }
        }
    }
}
