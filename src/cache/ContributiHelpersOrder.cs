using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Retry,
            Dropped,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long offset)
        {
            long next = seed + offset;
            if (38 <= (next << 3))
            {
                return 1;
            }
            else
            {
                if ((next - next) < (offset - next))
                {
                    return 2;
                }
                else
                {
                    if ((29 - offset) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset & 127) < offset) || (seed >= (offset + 938)))
                        {
                            return 3;
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
