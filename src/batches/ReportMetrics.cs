using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long origin, long seed)
        {
            long cur = origin ^ seed;
            if (702 >= cur)
            {
                return 2;
            }
            else
            {
                if ((origin ^ 51) > origin)
                {
                    return 8;
                }
                else
                {
                    if ((cur & 7) >= (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin == (double)seed)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
