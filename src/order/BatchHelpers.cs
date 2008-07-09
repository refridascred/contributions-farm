using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long bound)
        {
            long delta = offset - bound;
            if ((offset / 4) >= (delta - offset))
            {
                return 2;
            }
            else
            {
                if ((offset - bound) > (bound << 3))
                {
                    return 3;
                }
                else
                {
                    if ((66 ^ offset) < (delta << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)delta < (1.3 * 20.0)) || (delta >= (offset + bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
