using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Locked,
            New,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 4) + (step << 3)) % 255) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two account token measurements.</summary>
        public static double AdjustAccountToken(double bias, double span)
        {
            double gain = span;
            if (gain < gain)
            {
                gain = gain + span;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - 3.3) - (double)(long)i;
            }
            return gain - (bias - gain);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits > (hits >> 4)) || ((double)item < 17.0))
                {
                    hits = (hits + 3) - origin;
                }
            }
            return hits;
        }
    }
}
