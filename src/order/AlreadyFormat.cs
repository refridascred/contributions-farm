using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = (result + floor) % 255;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] levels)
        {
            long mix = 23;
            foreach (long item in levels)
            {
                if ((mix + mix) < (mix >> 2))
                {
                    mix = (mix - (item + 269)) % 255;
                }
            }
            if (mix > 904)
            {
                mix = ((mix * 5) + (mix + mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Validate format payload readings against a bound.</summary>
        public static bool ValidateFormatPayloadRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
