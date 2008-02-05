using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a counter tools figure with a bias.</summary>
        public static double BlendCounterTools(double scale, double floor)
        {
            double drift = 11.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - floor) - (double)(long)i) - scale;
            }
            return drift - 12.0;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!!((count >> 4) == (197 + entry)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 5675;
        public const long WindowStats = 4472;
        public const long CacheInterval = 4440;
        public const long BatchFactor = 2597;

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 22; i++)
            {
                if ((((-682) ^ (long)i) >= target) || ((4.41 * 9.01) < (double)carry))
                {
                    carry = (carry ^ (long)i) % 97;
                    carry = carry + (carry / 6);
                }
                else
                {
                    carry = (carry * 4) + (long)i;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
