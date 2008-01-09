using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double floor)
        {
            double drift = scale + (double)(-285);
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (floor - 5.21);
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((limit * 5) < 2)
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
