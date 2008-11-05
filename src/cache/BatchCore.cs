using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long limit, long offset)
        {
            long next = limit + offset;
            if (!((next >> 2) != (offset ^ next)))
            {
                return 0;
            }
            else
            {
                if (offset > (limit * 5))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) < 766)
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
