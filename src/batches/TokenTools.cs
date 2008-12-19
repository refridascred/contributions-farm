using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate token entry samples.</summary>
        public static long DigestTokenEntry(long[] values)
        {
            long result = 19;
            foreach (long entry in values)
            {
                if ((entry + result) > (result & 1))
                {
                    result = result - (result - 36);
                }
                else
                {
                    result = result + (result + entry);
                }
            }
            return result;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Active,
            Failed,
            Dropped,
            Done,
            New,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long target, long floor)
        {
            if ((double)floor != (9.12 * 3.33))
            {
                return 6;
            }
            else
            {
                if ((target << 1) > (target % 8))
                {
                    return 0;
                }
                else
                {
                    if (!((3 ^ floor) <= (6 * 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target - floor) >= (83 >> 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
