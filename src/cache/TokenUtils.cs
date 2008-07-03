using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionBounds(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
