using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the report session series from a seed.</summary>
        public static long StepReportSession(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a context counter pair into a bucket.</summary>
        public static long GradeContextCounter(long bound, long limit)
        {
            if ((0.22 + 2.1) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (2.56 > (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit & 31) >= limit) || ((9.0 + 9.88) <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound + limit) > (22 - bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((215 * 2) < hits))
                {
                    hits = ((hits + 1) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long bound, long floor)
        {
            long edge = bound - floor;
            if (((double)bound > (8.23 - 0.46)) && ((bound * 5) <= (170 * 4)))
            {
                return 7;
            }
            else
            {
                if ((double)edge >= (double)3)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 755;
        public const long BatchPayload = 7206;
        public const long HardDepth = 8807;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
