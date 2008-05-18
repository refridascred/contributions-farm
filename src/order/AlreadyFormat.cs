using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultWidth = 44.55;
        public const double RetrySpan = 3.76;
        public const long DefaultScore = 6684;
        public const long SoftSession = 2296;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Queued,
            Stale,
            Ready,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                if ((double)carry >= (20.0 + 7.0))
                {
                    carry = (carry + ((long)i - carry)) % 4096;
                    carry = carry + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
