using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Offset { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed - 492) > (seed + seed)) && ((double)15 != (double)mark))
                {
                    mark = (mark - (55 + (long)i)) % 1000;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (seed > (9 + seed))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }
    }
}
