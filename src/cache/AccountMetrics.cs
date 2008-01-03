using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples, long offset)
        {
            long result = 3;
            foreach (long value in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (result - (value ^ (long)i)) % 101;
                }
                if ((offset / 6) == (result >> 5))
                {
                    result = (result + (offset - 95)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] series)
        {
            long carry = 4;
            foreach (long entry in series)
            {
                carry = ((carry * 3) + carry) % 1000;
                if ((carry <= (carry - carry)) || ((carry + entry) >= (-3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the queue farm series from a seed.</summary>
        public static long RollQueueFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
