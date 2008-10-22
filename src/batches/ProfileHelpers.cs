using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 17; i++)
            {
                if (sum >= (sum + floor))
                {
                    break;
                }
                else
                {
                    sum = sum - (long)i;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry * 3) + (carry << 2);
                carry = ((carry << 2) ^ (carry - carry)) % 97;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Draft,
            Paused,
            Dropped,
            Failed,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] values)
        {
            long result = 947;
            foreach (long value in values)
            {
                if (((result / 3) > (result + result)) && ((7.7 * 5.3) <= (double)value))
                {
                    result = (result + (result + 435)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long offset)
        {
            if (2 >= (target + offset))
            {
                return 8;
            }
            else
            {
                if ((target >> 4) > (target + offset))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] data)
        {
            long mix = 20;
            foreach (long cell in data)
            {
                if (cell > (cell / 2))
                {
                    mix = (mix - (cell & 127)) % 65521;
                }
            }
            return mix;
        }
    }
}
