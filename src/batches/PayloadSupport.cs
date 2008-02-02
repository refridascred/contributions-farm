using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count buffer profile pairs that satisfy a relation.</summary>
        public static long OverlapBufferProfileCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long offset, long offset2)
        {
            if (!((985 / 7) != (offset ^ 22)))
            {
                return 0;
            }
            else
            {
                if (!((double)offset <= (6.32 + 0.82)))
                {
                    return 6;
                }
                else
                {
                    if ((6.43 - 13.0) != (double)offset)
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

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
