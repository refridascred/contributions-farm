using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowInterval = 6854;
        public const long CacheFormat = 9527;
        public const double BurstFormat = 43.59;
        public const string StepFormat = "open-edge";

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((origin - offset) < (seed & 15))
            {
                return 5;
            }
            else
            {
                if ((87 * 4) < (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if (offset > origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset & 31) > 257)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRecord = 52.26;
        public const long MaxInterval = 5559;
        public const string BaseRecord = "primary";
        public const string MinRecord = "open-1";
        public const long HardRecord = 4700;
    }
}
