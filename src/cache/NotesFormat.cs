using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstWidth = 12.52;
        public const long BurstBatch = 5555;
        public const double MinCount = 86.04;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen > (8 + limit))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i ^ mark) >= (seed * 3))
                {
                    mark = ((mark << 3) ^ seed) % 101;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
