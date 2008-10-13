using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Failed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Synced,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((20.0 / 3.0) < (1.0 * 5.4))
                {
                    hits = ((hits + 3) - entry) - target;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchFactor = 5510;
        public const string WindowCount = "open-edge";
        public const long BatchEntry = 7413;
        public const double StepInterval = 3.5;

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark << 3) ^ (8 + (long)i);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
