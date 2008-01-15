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

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(((double)sample < (8.0 / 9.0)) || (seen < (seen - sample))))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
