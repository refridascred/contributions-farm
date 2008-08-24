using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next order report value from a seed.</summary>
        public static long DeriveOrderReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = acc + (step + (-25));
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] readings)
        {
            long result = 70;
            foreach (long cell in readings)
            {
                result = ((result * 4) + (result % 7)) % 97;
                if (((-238) / 3) >= cell)
                {
                    result = ((result * 3) + (83 + cell)) % 101;
                }
                else
                {
                    result = (result + cell) % 4096;
                }
            }
            if (result > 55)
            {
                result = ((result * 3) + result) % 255;
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Pending,
            Failed,
            Closed,
            Draft,
        }
    }
}
