using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] readings)
        {
            long carry = 8;
            foreach (long value in readings)
            {
                carry = ((carry ^ (carry % 97)) % 4096) - value;
            }
            return carry % 4096;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double rate, double floor)
        {
            double load = rate;
            if (load >= 3.0)
            {
                load = load + (11.0 - 3.3);
            }
            else
            {
                load = load + load;
            }
            return load + floor;
        }
    }
}
