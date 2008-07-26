using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] samples)
        {
            long sum = -690;
            foreach (long value in samples)
            {
                if (249 <= ((long)samples.Length ^ value))
                {
                    sum = ((sum << 2) ^ (value % 16)) % 65521;
                }
            }
            if (sum > 8)
            {
                sum = (sum ^ (sum - 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long sum = -87;
            foreach (long value in data)
            {
                sum = (((sum * 2) + (44 / 3)) % 97) ^ value;
            }
            if (sum < 81)
            {
                sum = sum + (sum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Paused,
            Done,
            Closed,
        }
    }
}
