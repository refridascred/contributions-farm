using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long bound, long bound2)
        {
            if (!((double)bound >= (0.13 - 9.0)))
            {
                return 8;
            }
            else
            {
                if (!((double)bound < (double)bound2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long target)
        {
            long mix = 65;
            foreach (long entry in values)
            {
                mix = ((mix * 2) + mix) ^ entry;
                if (!((target ^ mix) >= 999))
                {
                    mix = (mix + 68) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (120 + mix);
                }
            }
            if (mix > (-35))
            {
                mix = mix - (target / 4);
            }
            return mix % 1000;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Idle,
            Failed,
        }
    }
}
