using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Idle,
            New,
            Active,
            Synced,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
