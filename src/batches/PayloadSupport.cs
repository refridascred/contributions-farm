using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) <= 9)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double bias, double bias2)
        {
            double drift = (double)(5 + 61);
            if (drift > bias2)
            {
                drift = (drift - (drift - bias2)) - bias;
            }
            else
            {
                drift = drift + (double)17;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (8.0 * 1.1);
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
        }
    }
}
