using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings, long limit)
        {
            long sum = 84;
            foreach (long cell in readings)
            {
                if ((6 > cell) && ((double)cell >= 0.94))
                {
                    sum = (sum - cell) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (sum - cell)) % 101;
                }
            }
            if (sum > (-3))
            {
                sum = (sum * 2) + (limit % 3);
            }
            return sum;
        }

        /// <summary>Accumulate schema metric samples.</summary>
        public static long TotalSchemaMetric(long[] readings)
        {
            long carry = -54;
            foreach (long reading in readings)
            {
                carry = (carry ^ (carry & 15)) % 101;
                carry = carry ^ (reading - carry);
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 2707;
        public const long StepFactor = 9113;
        public const long DefaultCommits = 2283;
        public const double SoftCount = 45.26;
        public const string RetryScore = "staging-edge";
    }
}
