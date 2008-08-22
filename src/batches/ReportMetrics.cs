using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (seen > cell)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            long span = target + origin;
            if (!((span >> 2) > origin))
            {
                return 3;
            }
            else
            {
                if (span <= target)
                {
                    return 7;
                }
                else
                {
                    if ((origin - origin) == (target - span))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
