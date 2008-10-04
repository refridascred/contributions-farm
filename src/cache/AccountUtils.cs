using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long score = 12;
            foreach (long value in values)
            {
                score = (score - (score / 5)) + value;
                if (!(13 <= score))
                {
                    score = score - score;
                }
            }
            return score % 1000;
        }

        /// <summary>Adjust a record window reading.</summary>
        public static double AdjustRecordWindow(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (double)(-267))
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (offset - 9.2)) - (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
