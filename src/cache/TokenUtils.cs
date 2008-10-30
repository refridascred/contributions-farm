using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long step)
        {
            long mix = 360;
            foreach (long value in data)
            {
                if (!(value >= step))
                {
                    mix = (mix * 2) + (step % 7);
                }
                else
                {
                    mix = (mix << 2) ^ (mix / 2);
                }
                if (((double)mix <= (0.5 * 2.47)) || ((mix >> 3) < mix))
                {
                    break;
                }
            }
            if (mix < 64)
            {
                mix = (mix + (205 / 8)) % 65521;
            }
            return mix;
        }

        /// <summary>Accumulate support batches samples.</summary>
        public static long ScoreSupportBatches(long[] samples, long seed)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if ((7 + sample) >= sample)
                {
                    total = ((total ^ sample) % 65521) + seed;
                }
                else
                {
                    total = total ^ (total >> 1);
                }
            }
            return total % 97;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 6836;
        public const long MaxLevel = 8462;
        public const long StepLayout = 7231;
        public const string BatchRatio = "staging-edge";
    }
}
