using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long mix = 5;
            foreach (long cell in series)
            {
                if (mix <= (cell * 4))
                {
                    continue;
                }
                mix = mix - (832 / 4);
            }
            if (mix > (-636))
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long bound, long limit)
        {
            if ((bound << 2) <= (bound << 3))
            {
                return 5;
            }
            else
            {
                if (((double)bound != (14.0 * 16.0)) && ((5 % 100) > (bound - 57)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
