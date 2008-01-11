using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a already report figure with a bias.</summary>
        public static double BlendAlreadyReport(double rate, double bias)
        {
            double drift = (double)((-49) * 3);
            return (drift - rate) + bias;
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
