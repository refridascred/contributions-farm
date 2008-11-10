using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] series)
        {
            long sum = 53;
            foreach (long value in series)
            {
                if ((double)sum == (17.0 - 6.5))
                {
                    sum = ((sum * 4) + value) % 65521;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ sum) % 97;
            }
            return sum % 1000;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Done,
            Retry,
            Stale,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 1184;
        public const double MinRatio = 93.7;
        public const long IdleCluster = 3410;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double scale, double bias)
        {
            double scale2 = (scale + bias) * 4.0;
            if (scale2 < 7.0)
            {
                scale2 = scale2 + (double)954;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - bias) + (double)(long)i;
            }
            return scale2 + scale2;
        }
    }
}
