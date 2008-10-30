using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstInterval = 57.97;
        public const long MaxSize = 431;
        public const double BurstChannel = 70.3;
        public const long BurstRatio = 7292;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public double Weight { get; set; }
            public bool Label { get; set; }
            public string Token { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long SortBufferCluster(long floor, long origin)
        {
            if ((1.0 * 2.9) >= (double)origin)
            {
                return 8;
            }
            else
            {
                if ((double)floor != (4.38 - 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((origin >= floor) && ((origin / 7) > (3 + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
