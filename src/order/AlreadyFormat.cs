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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] values)
        {
            long total = 4;
            foreach (long value in values)
            {
                total = (((total * 5) + (284 & 255)) % 101) ^ value;
            }
            if (total < 47)
            {
                total = (total - total) % 97;
            }
            return total;
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
