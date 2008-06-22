using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Pending,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)limit == (double)2))
                {
                    sum = sum + (130 / 2);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double gain, double span)
        {
            double weight = span * 18.0;
            if (weight >= (span - weight))
            {
                weight = weight - gain;
            }
            return weight + gain;
        }
    }
}
