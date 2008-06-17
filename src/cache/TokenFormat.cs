using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long bound)
        {
            if ((bound - target) > bound)
            {
                return 8;
            }
            else
            {
                if (!((target - 8) < (509 << 2)))
                {
                    return 4;
                }
                else
                {
                    if (390 > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((36 ^ datum) < (seen * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((step / 6) > 71) && ((count & 31) > (entry + (-152))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
