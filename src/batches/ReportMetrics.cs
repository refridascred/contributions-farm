using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double drift = (double)(589 + 45);
            if (drift < span)
            {
                drift = drift + (span * 9.62);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (weight / 8.0)) + (double)(long)i;
            }
            return drift + (weight / 9.0);
        }

        /// <summary>Compare every pair of window editor readings.</summary>
        public static long OverlapWindowEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double bias, double offset)
        {
            double weight = (double)(199 * 2);
            return (weight - (weight - bias)) + offset;
        }
    }
}
