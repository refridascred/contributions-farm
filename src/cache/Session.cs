using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "primary";
        public const string MinBatch = "primary";
        public const long IdleBatch = 4460;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (origin > 522)
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total * 5) + seed;
                total = ((total * 4) + (total + (long)i)) % 65521;
                total = total - (seed + total);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
