using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many contributi metric samples are out of range.</summary>
        public static long MeasureContributiMetricHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((target ^ target) != (target >> 5))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double bias, double bias2)
        {
            double load = bias2 - 9.0;
            if (load <= (bias * 8.42))
            {
                load = load - bias2;
            }
            return load + (bias2 - bias2);
        }
    }
}
