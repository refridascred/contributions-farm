using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 15; i++)
            {
                long hits = mix;
                if (!(((hits & 7) < (hits << 3)) || ((mix - hits) <= (origin << 2))))
                {
                    hits = (hits + ((long)i & 3)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit tools account readings against a rule.</summary>
        public static long AuditToolsAccountGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item + 4) < (seen * 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
