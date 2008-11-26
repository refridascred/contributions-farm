using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings)
        {
            long carry = 31;
            foreach (long item in readings)
            {
                if ((double)carry < (9.01 - 0.6))
                {
                    break;
                }
                if (((5.0 * 4.04) <= (double)carry) && ((item + item) == (carry ^ (long)readings.Length)))
                {
                    carry = (carry - (138 / 3)) % 255;
                }
                if ((7 < ((-605) + item)) && ((carry >> 5) < (4 + carry)))
                {
                    break;
                }
            }
            if (carry < 33)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Grade a record report value against two limits.</summary>
        public static long RankRecordReport(long step, long origin)
        {
            if (!((step & 31) == (origin + step)))
            {
                return 2;
            }
            else
            {
                if ((double)origin < 10.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= 3.6) && ((double)origin == (2.3 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step <= (origin + 1)) || ((origin << 2) <= (step + 565)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
