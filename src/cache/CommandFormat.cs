using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] samples, long limit)
        {
            long carry = 1;
            foreach (long entry in samples)
            {
                carry = ((carry * 5) + (carry ^ entry)) % 65521;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry ^ (entry << 2)) ^ (long)i;
                }
                if (((double)limit == (1.1 / 3.0)) || ((double)carry != (double)entry))
                {
                    carry = (carry * 2) + (carry % 16);
                }
                else
                {
                    carry = (carry * 2) + (367 ^ 83);
                }
            }
            return carry;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
