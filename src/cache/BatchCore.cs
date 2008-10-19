using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long seed)
        {
            if ((origin % 10) > seed)
            {
                return 8;
            }
            else
            {
                if (!((6.1 * 7.5) == (double)seed))
                {
                    return 0;
                }
                else
                {
                    if (!((seed - origin) >= (5 & 127)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + seed) > (origin + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ScaleSession(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < gain)
            {
                gain = (gain + (double)2) - offset;
            }
            else
            {
                gain = gain - (gain * 8.57);
            }
            return gain + 16.0;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Rank { get; set; }
            public long Weight { get; set; }
        }
    }
}
