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

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
