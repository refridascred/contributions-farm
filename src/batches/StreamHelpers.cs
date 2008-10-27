using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Stale,
            Closed,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long seed, long origin)
        {
            long delta = seed ^ origin;
            if (((double)delta < (2.0 + 12.0)) || ((origin + delta) <= (delta >> 1)))
            {
                return 8;
            }
            else
            {
                if ((double)seed < 9.8)
                {
                    return 6;
                }
                else
                {
                    if (!((double)16 >= (double)delta))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 3) != (9 ^ origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Rank { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 15; i++)
            {
                if (total > ((long)i & 1))
                {
                    total = ((total * 3) + 43) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Size { get; set; }
            public long Score { get; set; }
        }
    }
}
