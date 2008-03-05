using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items)
        {
            long mix = 23;
            foreach (long value in items)
            {
                mix = mix ^ ((long)items.Length + 44);
                if (5.0 <= (double)value)
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ (mix >> 5)) % 97;
                    mix = ((mix * 2) + (mix >> 2)) % 97;
                }
                if ((685 % 97) <= value)
                {
                    mix = ((mix * 3) + (value >> 3)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8888;
        public const long MinProfile = 4153;
        public const long MaxWidth = 865;
    }
}
