using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Done,
            Locked,
            Queued,
            New,
        }

        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double offset)
        {
            double load = offset;
            if (load >= (load / 4.0))
            {
                load = load + gain;
            }
            return load + gain;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch stats value.</summary>
        public static double AdjustBatchStats(double rate, double bias)
        {
            double mean = bias;
            if (mean <= (double)26)
            {
                mean = (mean + mean) + rate;
            }
            else
            {
                mean = mean - bias;
            }
            return mean - (double)55;
        }
    }
}
