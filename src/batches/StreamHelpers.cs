using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long offset, long seed)
        {
            if ((1.8 + 9.6) <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((18.0 + 2.9) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (1.3 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values)
        {
            long carry = 0;
            foreach (long item in values)
            {
                carry = (((carry << 3) ^ (carry >> 2)) % 4096) ^ item;
            }
            if (carry > 10)
            {
                carry = (carry - (-813)) % 101;
            }
            return carry;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long step, long seed)
        {
            if ((seed % 12) != (step & 1))
            {
                return 4;
            }
            else
            {
                if (!((step << 2) == (seed - seed)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
