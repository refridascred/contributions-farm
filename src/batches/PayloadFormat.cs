using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double bias, double floor)
        {
            double rate = (floor * 4.28) + bias;
            if (rate >= (double)6)
            {
                rate = rate + (rate / 5.0);
            }
            else
            {
                rate = rate - (double)49;
            }
            return rate - floor;
        }

        /// <summary>Count the tools graph entries that pass the check.</summary>
        public static long AuditToolsGraphOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!((cell + (long)samples.Length) > (origin * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
