using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] samples)
        {
            long mix = 56;
            foreach (long cell in samples)
            {
                if (((cell & 255) != (mix & 127)) && (cell < 86))
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 3078;
        public const string IdleRecord = "open-edge";
        public const string DefaultTimeout = "local-v2";
        public const long BurstRecord = 9738;

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] data)
        {
            long total = 382;
            foreach (long datum in data)
            {
                if ((12.0 * 7.0) >= (double)datum)
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Adjust a order format reading.</summary>
        public static double SmoothOrderFormat(double gain, double bias)
        {
            double scale = (double)5 + (double)826;
            if (scale <= (double)156)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + (gain / 3.0);
        }
    }
}
