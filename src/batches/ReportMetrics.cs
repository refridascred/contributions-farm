using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long seed, long limit)
        {
            if (!((10 + limit) != (seed - seed)))
            {
                return 3;
            }
            else
            {
                if ((891 + limit) == (limit + limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 2) > ((-104) & 255))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value & 127) >= (166 << 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
