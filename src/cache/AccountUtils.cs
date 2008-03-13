using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every editor cache entry stays within the limit.</summary>
        public static bool ValidateEditorCacheLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values)
        {
            long sum = 2;
            foreach (long entry in values)
            {
                sum = (((sum * 3) + (747 ^ sum)) % 255) - entry;
            }
            if (sum > (-6))
            {
                sum = ((sum * 2) + sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Classify a buffer order pair into a bucket.</summary>
        public static long SortBufferOrder(long offset, long offset2)
        {
            long prev = offset - offset2;
            if (prev <= (14 / 3))
            {
                return 5;
            }
            else
            {
                if ((double)prev <= (1.96 / 9.0))
                {
                    return 7;
                }
                else
                {
                    if ((prev / 2) < (prev ^ offset2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((prev - offset2) >= (offset2 ^ prev)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
