using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of batches layout readings.</summary>
        public static long TotalBatchesLayout(long[] readings, long seed)
        {
            long mix = 784;
            foreach (long sample in readings)
            {
                if ((seed % 10) >= seed)
                {
                    mix = (mix << 2) ^ (sample + seed);
                }
            }
            if (mix > 6)
            {
                mix = ((mix * 3) + (mix << 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Find the first channel editor entry that matches the target.</summary>
        public static long LookupChannelEditorIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
