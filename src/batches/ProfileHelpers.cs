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

        /// <summary>Compare every pair of record report readings.</summary>
        public static long OverlapRecordReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
