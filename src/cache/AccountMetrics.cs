using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double scale, double floor)
        {
            double rate = (double)(2 >> 4);
            if (rate >= (floor - 4.0))
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate + (double)3;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count the context channel entries that pass the check.</summary>
        public static long AuditContextChannelMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count <= (bound + bound))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample >= ((long)values.Length % 3)) && ((seed - 41) >= (hits >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long limit, long offset)
        {
            long span = limit + offset;
            if ((span - span) != (57 / 8))
            {
                return 8;
            }
            else
            {
                if (((-4) + limit) <= offset)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepCount = 7421;
        public const long SoftSpan = 9598;
        public const long BurstCount = 5897;
    }
}
