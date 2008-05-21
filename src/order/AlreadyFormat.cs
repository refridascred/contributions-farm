using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum + (sum - 39)) % 1000;
                sum = (sum + origin) % 101;
                if ((double)sum > (1.87 - 2.0))
                {
                    sum = (sum << 3) ^ (origin * 5);
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long carry = 431;
            foreach (long datum in data)
            {
                carry = (carry + (carry >> 5)) - datum;
                if (((carry * 2) <= seed) && (seed > (seed / 2)))
                {
                    carry = carry ^ (carry / 6);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 3964;
        public const double WindowAlready = 83.76;
        public const long BurstAlready = 9936;
    }
}
