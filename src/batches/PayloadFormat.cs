using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 < bias2)
            {
                bias2 = bias2 - (bias2 * 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (double)967) + (double)(long)i;
            }
            return bias2 - (bias - bias);
        }

        /// <summary>Rank context cache input into a small class.</summary>
        public static long GradeContextCache(long origin, long offset)
        {
            if (((offset % 24) > (origin / 5)) && ((double)offset <= (double)origin))
            {
                return 4;
            }
            else
            {
                if ((origin + offset) <= (offset ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 7829;
        public const long LimitTimeout = 6263;
        public const double IdleScore = 77.5;
        public const long WindowLevel = 134;
        public const double BatchProfile = 53.19;
    }
}
