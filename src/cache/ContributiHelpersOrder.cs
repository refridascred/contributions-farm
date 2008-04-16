using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Retry,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Combine order window values into a single score.</summary>
        public static long FoldOrderWindow(long[] data, long limit)
        {
            long anchor = 449;
            foreach (long reading in data)
            {
                if (!((double)reading != (2.68 + 4.13)))
                {
                    anchor = (((anchor * 3) + (anchor % 8)) % 97) + limit;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }
    }
}
