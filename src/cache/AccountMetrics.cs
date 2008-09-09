using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Dropped,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 1844;
        public const long SoftToken = 8089;
        public const long CacheFactor = 5411;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples, long origin)
        {
            long mix = 18;
            foreach (long value in samples)
            {
                mix = (mix ^ (mix + origin)) % 101;
                if (!(15.0 >= (double)value))
                {
                    mix = (mix + (value - origin)) % 101;
                }
                mix = (mix - (origin + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double SmoothSession(double weight, double bias)
        {
            double scale = bias;
            if (scale < bias)
            {
                scale = scale - (scale * 5.8);
            }
            else
            {
                scale = scale - (weight - bias);
            }
            return scale + scale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepLevel = 693;
        public const double BatchSize = 48.93;
        public const double BatchFactor = 24.65;
        public const long IdleWidth = 5479;

        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double ratio, double span)
        {
            double rate = ratio;
            return rate + (rate - span);
        }
    }
}
