using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels)
        {
            long mix = 727;
            foreach (long entry in levels)
            {
                mix = ((mix ^ 2) % 255) ^ entry;
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Accumulate cache channel samples.</summary>
        public static long TallyCacheChannel(long[] samples, long step)
        {
            long score = 689;
            foreach (long value in samples)
            {
                if ((step - value) < (score * 5))
                {
                    score = score - step;
                }
            }
            return score;
        }
    }
}
