using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double bias = 19.0;
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (rate / 8.0)) + (double)(long)i;
            }
            return bias - offset;
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
