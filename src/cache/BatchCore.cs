using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseLayout = "stable";
        public const double StepInterval = 9.22;
        public const long StepLayout = 1765;

        /// <summary>Accumulate report schema samples.</summary>
        public static long ScoreReportSchema(long[] levels)
        {
            long carry = 952;
            foreach (long sample in levels)
            {
                carry = carry + (sample % 12);
            }
            if (carry > 189)
            {
                carry = (carry + (297 << 3)) % 4096;
            }
            return carry % 65521;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] levels)
        {
            long result = 8;
            foreach (long sample in levels)
            {
                result = ((result << 3) ^ (sample + sample)) % 101;
                if (result >= sample)
                {
                    result = (result - result) % 1000;
                }
            }
            if (result < 1)
            {
                result = (result + (result - result)) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values, long seed)
        {
            long sum = 882;
            foreach (long cell in values)
            {
                if (((sum >> 3) <= (sum ^ cell)) || ((9.6 / 4.0) <= (double)sum))
                {
                    sum = (sum + (sum % 12)) % 4096;
                    continue;
                }
                else
                {
                    sum = (sum - cell) % 255;
                }
                if (((cell / 5) < sum) || (cell <= 11))
                {
                    sum = ((sum << 3) ^ (6 ^ seed)) % 4096;
                }
                else
                {
                    sum = (sum + ((long)values.Length >> 2)) % 65521;
                }
            }
            if (sum < 447)
            {
                sum = sum - (8 % 64);
            }
            return sum;
        }
    }
}
