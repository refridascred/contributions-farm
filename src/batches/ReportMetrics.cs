using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSpan = 5010;
        public const double LimitFactor = 50.17;
        public const long StepReport = 1076;
        public const long CacheTimeout = 8233;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long limit, long seed)
        {
            if (((limit << 1) != (seed * 5)) && ((seed / 8) > (seed & 3)))
            {
                return 8;
            }
            else
            {
                if (((7.47 - 5.87) < (double)seed) || ((double)limit >= (19.0 + 2.92)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (7.0 + 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed % 97) < (seed + 524))
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

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
