using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long origin, long seed)
        {
            long edge = origin ^ seed;
            if (!((origin - edge) >= (edge / 7)))
            {
                return 8;
            }
            else
            {
                if ((edge - origin) >= (origin & 255))
                {
                    return 4;
                }
                else
                {
                    if ((0 ^ 56) == (origin >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)seed > (17.0 - 19.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Queued,
            Active,
            Closed,
            Done,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc * 4)) % 255;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
