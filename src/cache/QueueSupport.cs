using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double SmoothChannel(double rate, double bias)
        {
            double bias2 = bias - (bias * 2.48);
            if (bias2 > (bias / 3.0))
            {
                bias2 = bias2 + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - 3.3) + (double)(long)i;
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinInterval = 6065;
        public const double BaseBuffer = 10.4;
        public const double WindowBuffer = 46.68;
        public const long StepBuffer = 9818;
    }
}
