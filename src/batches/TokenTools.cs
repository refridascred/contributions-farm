using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit payload entry readings against a rule.</summary>
        public static long MeasurePayloadEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen / 3) <= (391 + seen))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer command pair into a bucket.</summary>
        public static long BucketBufferCommand(long origin, long offset)
        {
            long span = origin ^ offset;
            if (offset > span)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (double)span)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
