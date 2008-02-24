using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Ready,
            Dropped,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Blend two graph already measurements.</summary>
        public static double SmoothGraphAlready(double rate, double bias)
        {
            double drift = (double)(320 + 950);
            if (drift >= (9.06 * 3.86))
            {
                drift = (drift - (bias + drift)) - rate;
            }
            else
            {
                drift = drift - (double)0;
            }
            return drift + (4.0 + drift);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryWidth = 54.09;
        public const long BurstTimeout = 8228;
        public const string StepLevel = "alpha-edge";

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Count { get; set; } = "";
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long floor, long bound)
        {
            long offset = floor ^ bound;
            if ((407 < (offset + floor)) && (bound < (31 & 1)))
            {
                return 8;
            }
            else
            {
                if ((offset << 3) != (floor - floor))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 4) != (floor / 3)) || ((double)floor < 4.6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor - bound) != (bound + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
