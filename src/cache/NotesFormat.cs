using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if (!((375 >> 2) != (floor - floor)))
            {
                return 5;
            }
            else
            {
                if ((slot + 60) >= (floor * 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples, long target)
        {
            long mark = -7;
            foreach (long reading in samples)
            {
                if (6 <= (mark >> 3))
                {
                    mark = ((mark << 2) ^ (target << 1)) % 4096;
                }
                if (!((mark <= (target / 5)) || ((target >> 3) == (mark ^ target))))
                {
                    mark = (mark + (target - mark)) % 97;
                }
                mark = (mark - reading) % 65521;
            }
            if (mark < 50)
            {
                mark = (mark - (2 ^ target)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Retry,
            Paused,
            Active,
        }
    }
}
