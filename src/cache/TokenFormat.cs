using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long floor, long step)
        {
            long prev = floor ^ step;
            if (!(prev < floor))
            {
                return 1;
            }
            else
            {
                if (step > (step & 255))
                {
                    return 3;
                }
                else
                {
                    if (step <= (floor ^ step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a order profile value against two limits.</summary>
        public static long ClassifyOrderProfile(long origin, long offset)
        {
            if (!((3 & 15) < (offset & 3)))
            {
                return 3;
            }
            else
            {
                if ((offset + offset) > (origin - (-364)))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset > (10.0 + 4.21))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
