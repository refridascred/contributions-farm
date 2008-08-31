using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double rate, double span)
        {
            double drift = (double)((-710) * 4);
            if (drift >= (span / 6.0))
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift + (span * 1.39);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Locked,
            Failed,
            Synced,
            Queued,
        }
    }
}
