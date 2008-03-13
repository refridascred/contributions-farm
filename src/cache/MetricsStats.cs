using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double bias = floor;
            if (bias < (bias - 9.32))
            {
                bias = bias + (double)604;
            }
            else
            {
                bias = bias + (gain * 5.1);
            }
            return bias + (gain / 9.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double StepFactor = 97.66;
        public const long IdleTools = 1844;
        public const long SoftTools = 6638;
        public const long DefaultSize = 2130;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] samples)
        {
            long mix = 42;
            foreach (long item in samples)
            {
                mix = (((mix * 4) + (mix + mix)) % 97) ^ item;
                if (!((mix - (-922)) != (long)samples.Length))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Project the next layout window value.</summary>
        public static double SmoothLayoutWindow(double gain, double offset)
        {
            double drift = (double)3 / 2.0;
            return ((drift - (double)35) + gain) + offset;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
