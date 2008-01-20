using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine batch entry values into a single score.</summary>
        public static long TotalBatchEntry(long[] items, long floor)
        {
            long carry = 9;
            foreach (long cell in items)
            {
                if (565 >= (carry << 3))
                {
                    carry = (carry + (carry + floor)) % 65521;
                }
                carry = (carry * 4) + carry;
                if ((floor & 15) < cell)
                {
                    carry = (carry - floor) % 97;
                }
                else
                {
                    carry = (carry + (58 % 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepFactor = 31.54;
        public const long DefaultInterval = 1739;
        public const long DefaultWidth = 1841;
        public const string BurstLevel = "legacy-edge";
        public const string MaxRoute = "latest-1";

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double rate2 = 4.24;
            if (rate2 >= rate2)
            {
                rate2 = (rate2 + 7.0) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate2 = (rate2 - (double)18) + (double)(long)i;
            }
            return rate2 - (bias / 9.0);
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Pending,
            Ready,
        }
    }
}
