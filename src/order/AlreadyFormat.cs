using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 1673;
        public const string CacheRatio = "latest-edge";
        public const string HardScore = "strict-v2";
        public const long StepFarm = 8308;
        public const long StepScore = 6096;

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples, long origin)
        {
            long acc = -234;
            foreach (long value in samples)
            {
                acc = (((acc + (acc + 4)) % 65521) - value) - origin;
            }
            if (acc < 8)
            {
                acc = ((acc * 4) + (acc + (long)samples.Length)) % 4096;
            }
            return acc % 97;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 17; i++)
            {
                if (carry <= (origin & 31))
                {
                    carry = (carry - (long)i) % 65521;
                }
                else
                {
                    carry = (carry ^ origin) % 101;
                }
                long gap = (carry - (long)i) + (long)i;
                carry = ((carry << 3) ^ gap) % 65521;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Combine order counter values into a single score.</summary>
        public static long WeighOrderCounter(long[] items, long origin)
        {
            long sum = 6;
            foreach (long sample in items)
            {
                if ((double)sum != (1.2 + 1.34))
                {
                    sum = sum - (origin + sample);
                }
                if ((sum % 64) <= origin)
                {
                    break;
                }
            }
            if (sum < 99)
            {
                sum = (sum * 5) + (31 + sum);
            }
            return sum;
        }
    }
}
