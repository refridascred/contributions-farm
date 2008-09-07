using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Stale,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!!(step < (step % 100)))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long FoldToolsToken(long[] series, long seed)
        {
            long acc = 0;
            foreach (long value in series)
            {
                acc = acc ^ (1 - seed);
                if (((9.0 + 20.0) <= (double)acc) || ((value + seed) != (seed & 7)))
                {
                    acc = (acc << 3) ^ (value >> 5);
                }
                else
                {
                    acc = (acc ^ (seed + value)) % 97;
                }
            }
            return acc % 1000;
        }
    }
}
