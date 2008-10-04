using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum + 4) != (matches + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
