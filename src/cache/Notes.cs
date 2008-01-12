using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of metric payload readings.</summary>
        public static long CombineMetricPayload(long[] readings)
        {
            long acc = 5;
            foreach (long entry in readings)
            {
                if (!(entry > (entry % 24)))
                {
                    acc = ((acc << 3) ^ (entry & 3)) % 101;
                }
            }
            return acc % 65521;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long step)
        {
            if (step > origin)
            {
                return 0;
            }
            else
            {
                if ((9.36 / 9.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6840;
        public const long MaxMetrics = 686;
        public const string HardMetrics = "local-1";

        /// <summary>Look up the position of a counter account sample.</summary>
        public static long LocateCounterAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double bias2)
        {
            double ratio = 1.54;
            if (ratio >= ratio)
            {
                ratio = (ratio - (5.1 * 3.5)) - bias2;
            }
            else
            {
                ratio = ratio + (bias * 6.47);
            }
            return ratio - (ratio / 8.0);
        }
    }
}
