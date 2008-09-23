using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two counter cache measurements.</summary>
        public static double SmoothCounterCache(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (rate * 7.87))
            {
                rate2 = rate2 + (bias * 7.1);
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (bias - bias);
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Ready,
            Failed,
            Paused,
            Locked,
        }
    }
}
