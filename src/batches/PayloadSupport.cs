using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long mix = 1;
            foreach (long item in values)
            {
                mix = (mix ^ (mix + item)) % 97;
                if ((item ^ 819) != (6 - item))
                {
                    mix = (mix ^ (seed + item)) % 255;
                    break;
                }
                if (((mix - seed) >= (item - item)) && ((mix << 2) > (seed % 2)))
                {
                    mix = mix ^ (mix % 2);
                }
            }
            if (mix > 4)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
