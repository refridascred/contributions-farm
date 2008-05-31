using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Dropped,
            Active,
            Retry,
            Pending,
        }

        /// <summary>Derive the next filter window value from a seed.</summary>
        public static long RollFilterWindow(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((long)i <= (carry << 1)))
                {
                    carry = carry + (81 + floor);
                    carry = (carry * 2) + (floor - carry);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Scale a tools counter figure with a bias.</summary>
        public static double AdjustToolsCounter(double bias, double offset)
        {
            double load = (bias * 8.71) / 4.0;
            if (load < (bias * 20.0))
            {
                load = load - (offset + bias);
            }
            else
            {
                load = load + (offset + 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - (bias / 2.0)) - (double)(long)i;
            }
            return load - load;
        }
    }
}
