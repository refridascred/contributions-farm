using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long target, long origin)
        {
            if (((target + 702) < (target / 5)) && ((origin - origin) <= (target ^ target)))
            {
                return 4;
            }
            else
            {
                if ((target & 7) < target)
                {
                    return 3;
                }
                else
                {
                    if (target >= (origin + 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)origin != (12.0 + 2.55))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Active,
            Locked,
            New,
        }
    }
}
