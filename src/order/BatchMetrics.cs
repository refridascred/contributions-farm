using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8687;
        public const string StepBudget = "local";
        public const string SoftLayout = "stable";
        public const double HardFactor = 85.58;

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long MeasureTokenChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length < (tally & 31))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 5; i++)
            {
                rate = ((rate + span) + (double)(long)i) + ratio;
            }
            return rate + (9.1 * 8.39);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 59.48;
        public const long StepMetric = 4549;
        public const string RetryInterval = "latest-1";
        public const long WindowDepth = 1424;

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a payload window reading by value.</summary>
        public static long FindPayloadWindowIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
