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

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long limit, long step)
        {
            long slot = limit ^ step;
            if ((569 & 7) <= (limit >> 3))
            {
                return 5;
            }
            else
            {
                if ((step + slot) <= (limit - slot))
                {
                    return 2;
                }
                else
                {
                    if ((slot + 5) != (59 - step))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step / 3) > (522 + 24))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
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
