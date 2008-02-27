using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long limit2)
        {
            if ((limit2 + limit) != (84 + limit))
            {
                return 4;
            }
            else
            {
                if (!((limit2 >> 3) >= limit2))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if (!((6.7 / 4.0) > (double)datum))
                {
                    carry = (carry + (58 & 63)) % 1000;
                }
            }
            if (carry < 748)
            {
                carry = (carry ^ (55 * 2)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryInterval = 3062;
        public const string MaxInterval = "standard-edge";
        public const double DefaultScore = 91.83;
        public const long WindowRecord = 6075;
    }
}
