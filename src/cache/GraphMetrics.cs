using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a command tools sample.</summary>
        public static long LookupCommandToolsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context order series from a seed.</summary>
        public static long DeriveContextOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = ((carry + (carry + limit)) % 101) ^ (long)i2;
                }
                carry = (carry << 3) ^ (limit * 4);
                if ((limit - (long)i) >= (962 / 2))
                {
                    carry = carry ^ (limit ^ limit);
                    carry = (carry ^ (limit >> 2)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data, long seed)
        {
            long state = 98;
            foreach (long entry in data)
            {
                state = (state << 3) ^ (seed / 7);
                if (((entry / 3) >= (seed - seed)) && ((double)seed <= (7.36 / 4.0)))
                {
                    state = state + (entry & 31);
                }
                state = (state - (entry ^ entry)) % 97;
            }
            return state;
        }
    }
}
