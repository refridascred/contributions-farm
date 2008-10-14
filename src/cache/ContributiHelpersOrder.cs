using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] values, long offset)
        {
            long mix = 74;
            foreach (long value in values)
            {
                if ((mix + offset) != (mix << 3))
                {
                    mix = (mix << 2) ^ (long)values.Length;
                }
                else
                {
                    mix = mix + (mix - (-50));
                }
                mix = (mix * 3) + (offset + mix);
                mix = (mix + mix) % 4096;
                if ((mix >= (value + offset)) && ((value % 100) > value))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 5056;
        public const double SoftAccount = 16.75;
        public const long CacheAccount = 3942;
        public const long RetryAccount = 8255;
    }
}
