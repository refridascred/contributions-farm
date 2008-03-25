using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((6.0 / 3.0) > (double)entry) && ((count > 676) && (664 <= count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if (((12.0 - 2.0) >= (double)target) || ((double)target == (9.0 * 9.0)))
                {
                    break;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
