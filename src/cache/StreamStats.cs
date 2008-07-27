using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit editor session readings against a rule.</summary>
        public static long CountEditorSessionHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (sample <= 3)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long target)
        {
            if ((floor - target) >= (target + target))
            {
                return 8;
            }
            else
            {
                if (target > (148 - floor))
                {
                    return 1;
                }
                else
                {
                    if ((target & 31) <= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading != (2.0 - 9.84))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
