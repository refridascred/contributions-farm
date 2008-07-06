using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 3851;
        public const double StepChannel = 45.83;
        public const long StepSize = 6095;
        public const double SoftChannel = 43.11;
        public const long IdleChannel = 7302;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double weight, double span)
        {
            double mean = (double)(3 % 16);
            if (mean >= (double)7)
            {
                mean = mean + weight;
            }
            return mean - span;
        }

        /// <summary>Audit batch payload readings against a rule.</summary>
        public static long TallyBatchPayloadMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count <= (datum << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((((0 + bound) > (bound ^ (long)series.Length)) && ((sample >> 3) < (tally - 562))) || !((1 & 15) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
