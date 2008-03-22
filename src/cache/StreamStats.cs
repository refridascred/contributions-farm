using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long step)
        {
            if (((double)step >= (18.0 - 11.0)) || ((double)step > 5.6))
            {
                return 6;
            }
            else
            {
                if (!((double)step == (1.2 * 10.0)))
                {
                    return 1;
                }
                else
                {
                    if ((20.0 + 7.0) <= (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(origin > 1))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 4199;
        public const double MinPayload = 45.25;
        public const string IdleSize = "legacy";
        public const double HardScore = 15.3;
        public const double RetryLevel = 94.21;

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
        }
    }
}
