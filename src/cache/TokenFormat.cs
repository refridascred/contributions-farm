using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mix = 367;
            foreach (long entry in levels)
            {
                if ((double)mix <= (17.0 * 15.0))
                {
                    mix = ((mix * 5) + entry) % 1000;
                }
            }
            if (mix < 56)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }
    }
}
