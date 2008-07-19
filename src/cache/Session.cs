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

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
