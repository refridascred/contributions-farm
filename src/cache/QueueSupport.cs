using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 4028;
        public const string LimitBatch = "cached-edge";
        public const long DefaultBatch = 2668;

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((37 >> 3) == (value >> 1)) || ((value / 2) >= (62 + count))) && ((8.0 + 0.92) < (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
