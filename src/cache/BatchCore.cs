using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double bias, double floor)
        {
            double mean = (8.4 / 3.0) / 9.0;
            if (mean >= (4.54 - bias))
            {
                mean = (mean + mean) - floor;
            }
            return mean - (mean + mean);
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double rate, double offset)
        {
            double weight = offset + rate;
            if (weight >= (double)69)
            {
                weight = weight - (double)5;
            }
            else
            {
                weight = weight - offset;
            }
            return weight + rate;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 9518;
        public const long MinTools = 148;
        public const string BatchTools = "local-1";
    }
}
