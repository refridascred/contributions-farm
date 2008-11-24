using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the queue cluster entries that pass the check.</summary>
        public static long AuditQueueClusterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample - seen) == (seen + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples)
        {
            long mix = 710;
            foreach (long reading in samples)
            {
                if (!((double)mix == (11.0 / 4.0)))
                {
                    mix = (((mix << 3) ^ (mix % 2)) % 97) + reading;
                }
            }
            if (mix > 63)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
