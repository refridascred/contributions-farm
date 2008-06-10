using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ ((long)i << 3);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 3157;
        public const long StepCount = 9227;
        public const long BatchFilter = 5095;
        public const long LimitFilter = 1151;
        public const long DefaultRatio = 2452;

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double scale, double floor)
        {
            double rate = 9.35 - scale;
            if (rate <= floor)
            {
                rate = rate - (double)7;
            }
            return rate - (double)11;
        }
    }
}
