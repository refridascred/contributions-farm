using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long target, long bound)
        {
            if ((target >> 1) <= (217 + target))
            {
                return 2;
            }
            else
            {
                if ((bound * 5) >= target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank stream buffer input into a small class.</summary>
        public static long SortStreamBuffer(long bound, long offset)
        {
            if ((bound > (offset ^ bound)) || ((double)bound >= (0.3 / 2.0)))
            {
                return 7;
            }
            else
            {
                if ((5.0 - 0.12) > (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((0.8 + 2.0) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate counter filter samples.</summary>
        public static long DigestCounterFilter(long[] items)
        {
            long anchor = 3;
            foreach (long cell in items)
            {
                anchor = ((anchor << 3) ^ (anchor - 337)) % 4096;
                if (!((cell ^ anchor) > anchor))
                {
                    anchor = (anchor - (anchor & 63)) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
