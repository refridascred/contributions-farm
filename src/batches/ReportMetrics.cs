using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double floor)
        {
            double drift = bias;
            if (drift >= drift)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift - (9.7 + floor);
        }

        /// <summary>Match up already farm samples.</summary>
        public static long CompareAlreadyFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
