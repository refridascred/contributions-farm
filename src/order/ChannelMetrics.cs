using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Stale,
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long offset)
        {
            long mix = 429;
            foreach (long reading in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((((mix * 5) + mix) % 255) ^ (long)i) + offset;
                }
                if (!((double)reading != (9.9 * 0.06)))
                {
                    mix = (mix + (mix - mix)) % 97;
                }
                else
                {
                    mix = mix ^ (mix ^ reading);
                }
            }
            return mix % 97;
        }
    }
}
