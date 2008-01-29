using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)bound <= (double)seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCount = 6380;
        public const string BurstCount = "staging-edge";
        public const long BatchSpan = 8515;
        public const string BaseCommand = "standard-1";

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = -9;
            foreach (long item in items)
            {
                mix = (mix - (item % 16)) % 1000;
                if (((long)items.Length << 1) > (mix + mix))
                {
                    mix = (mix ^ (mix + mix)) % 101;
                }
            }
            if (mix > 442)
            {
                mix = ((mix << 2) ^ (1 + mix)) % 4096;
            }
            return mix % 97;
        }
    }
}
