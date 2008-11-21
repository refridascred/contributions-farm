using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Level { get; set; }
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Locked,
            Failed,
            Queued,
            New,
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double mean = bias;
            if (mean > floor)
            {
                mean = mean + (bias + mean);
            }
            else
            {
                mean = mean - (6.4 - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean - bias)) + (double)(long)i;
            }
            return mean - (floor * 5.8);
        }
    }
}
