using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a format already pair into a bucket.</summary>
        public static long RankFormatAlready(long offset, long floor)
        {
            if ((offset > (offset * 3)) || (57 < (offset + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset << 2) >= (5 * 3))
                {
                    return 8;
                }
                else
                {
                    if (((offset / 4) >= (offset + offset)) || ((double)offset <= (8.6 / 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (747 + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepDepth = "strict-1";
        public const long SoftWidth = 3146;
        public const long IdlePayload = 9740;

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
