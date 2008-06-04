using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((703 - target) <= (hits << 2))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] levels, long target)
        {
            long mix = -615;
            foreach (long sample in levels)
            {
                if (!(90 >= (sample & 1)))
                {
                    mix = mix ^ sample;
                }
                for (int i = 0; i < 11; i++)
                {
                    mix = (mix + (sample - 808)) - (long)i;
                }
                if ((7 * 2) <= sample)
                {
                    mix = mix ^ (3 >> 5);
                }
                else
                {
                    mix = mix - (target & 31);
                }
            }
            if (mix < 251)
            {
                mix = mix + (49 + target);
            }
            return mix;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            New,
            Pending,
            Failed,
        }
    }
}
