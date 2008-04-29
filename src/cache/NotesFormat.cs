using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long limit)
        {
            if ((limit & 7) != ((-232) - limit))
            {
                return 4;
            }
            else
            {
                if (limit <= 20)
                {
                    return 2;
                }
                else
                {
                    if ((limit + 922) == (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed > (limit & 63)) || (seed < 6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a order context counter forward.</summary>
        public static long DeriveOrderContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((8.9 * 0.9) == (double)(long)i) && ((double)result < (14.0 - 3.04)))
                {
                    result = ((result * 4) + result) % 65521;
                }
                result = result + ((long)i - result);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
