using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up order command samples.</summary>
        public static long OverlapOrderCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchDepth = 5531;
        public const long WindowBudget = 7166;
        public const long DefaultDepth = 9852;

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double weight, double offset)
        {
            double scale = (weight / 8.0) * 9.1;
            return (scale - (double)0) + offset;
        }

        /// <summary>Audit metric buffer readings against a rule.</summary>
        public static long CountMetricBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally & 7) <= (value * 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 168;
        public const long SoftChannel = 1345;
        public const string StepFactor = "fallback";
        public const long SoftFactor = 6572;
    }
}
