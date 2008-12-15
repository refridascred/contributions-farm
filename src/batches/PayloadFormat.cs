using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the queue cache series from a seed.</summary>
        public static long RollQueueCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((20.0 / 2.0) >= (double)origin))
                {
                    carry = (carry ^ ((long)i - origin)) % 97;
                    carry = carry ^ ((long)i ^ carry);
                }
                else
                {
                    carry = (carry + ((-2) >> 5)) % 101;
                }
                if (((origin + 69) == (origin - origin)) || (carry > origin))
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepDepth = 4795;
        public const double CacheSupport = 65.71;
        public const long CacheTimeout = 1971;
        public const long IdleInterval = 5257;

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long offset, long floor)
        {
            if (offset < (floor + floor))
            {
                return 1;
            }
            else
            {
                if (485 < (floor >> 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset + offset) >= (236 % 64))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - 868) < (floor - offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
