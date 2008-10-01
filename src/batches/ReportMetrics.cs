using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a session order value against two limits.</summary>
        public static long RankSessionOrder(long origin, long seed)
        {
            if (((seed + 636) <= seed) && ((seed + 10) > seed))
            {
                return 2;
            }
            else
            {
                if ((5.6 / 6.0) >= 9.0)
                {
                    return 1;
                }
                else
                {
                    if ((7 << 2) > (origin + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first editor buffer entry that matches the target.</summary>
        public static long SeekEditorBufferIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Level { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }
    }
}
