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

        /// <summary>Derive the next metric layout value from a seed.</summary>
        public static long RollMetricLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
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
