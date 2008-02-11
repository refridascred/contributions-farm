using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double mean = (ratio * 3.72) + (ratio - offset);
            if (mean >= (mean * 5.99))
            {
                mean = mean + (mean - ratio);
            }
            return mean + ratio;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 493;
        public const double MinWindow = 0.68;
        public const long SoftWindow = 7775;
        public const long MaxWindow = 8836;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)target < (10.0 / 6.0))
                {
                    sum = (sum * 4) + 39;
                }
                else
                {
                    sum = (sum ^ ((long)i >> 3)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
