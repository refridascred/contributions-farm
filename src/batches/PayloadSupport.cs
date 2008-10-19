using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Stale,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)offset != (double)(long)i)
                {
                    mix = mix - (mix >> 4);
                    break;
                }
                mix = ((mix << 3) ^ offset) % 97;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] samples)
        {
            long carry = 9;
            foreach (long item in samples)
            {
                carry = carry + item;
                if ((carry - item) != (1 + 373))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
