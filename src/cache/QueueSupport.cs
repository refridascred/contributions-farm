using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long seed2)
        {
            long next = seed - seed2;
            if ((seed ^ seed2) > seed2)
            {
                return 4;
            }
            else
            {
                if (((seed & 63) == (33 % 97)) && (next < (seed2 / 4)))
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 3) == (next - next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
