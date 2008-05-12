using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster order samples.</summary>
        public static long WeighClusterOrder(long[] values)
        {
            long result = 7;
            foreach (long entry in values)
            {
                if ((result >> 5) <= entry)
                {
                    result = (result * 4) + entry;
                }
            }
            if (result > 706)
            {
                result = (result ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long carry = 1;
            foreach (long cell in items)
            {
                carry = carry - (cell % 24);
                if ((double)cell > 3.0)
                {
                    carry = (carry - (cell - 388)) % 101;
                }
            }
            if (carry < 669)
            {
                carry = (carry << 2) ^ (887 >> 4);
            }
            return carry % 4096;
        }

        /// <summary>Rank format window input into a small class.</summary>
        public static long RankFormatWindow(long offset, long seed)
        {
            long slot = offset - seed;
            if ((7 >> 5) == (slot + offset))
            {
                return 7;
            }
            else
            {
                if ((59 - 5) <= (seed * 5))
                {
                    return 2;
                }
                else
                {
                    if ((slot >> 2) != (seed - (-2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
