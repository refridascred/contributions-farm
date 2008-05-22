using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long offset)
        {
            long delta = origin + offset;
            if (547 <= (offset ^ 4))
            {
                return 7;
            }
            else
            {
                if (3.4 > (double)57)
                {
                    return 6;
                }
                else
                {
                    if ((576 & 255) != (origin / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((delta - origin) == ((-115) + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double bias)
        {
            double drift = weight * 9.0;
            if (drift < weight)
            {
                drift = (drift - drift) - bias;
            }
            return drift + weight;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 1755;
        public const double BaseCommand = 80.76;
        public const string StepCount = "open-edge";
    }
}
