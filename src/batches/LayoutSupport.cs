using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardInterval = 7761;
        public const double SoftEntry = 35.48;
        public const long MaxEntry = 748;
        public const long DefaultSize = 7609;

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next cache channel value from a seed.</summary>
        public static long SeriesCacheChannel(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix << 3) ^ (mix + mix)) % 97;
                mix = mix ^ (mix % 16);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
