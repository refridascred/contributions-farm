using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((-168) + count) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitTimeout = "standard";
        public const long SoftEntry = 2855;
        public const long StepEntry = 8483;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((floor - seen) <= (datum + 8)) || (((floor % 16) == (0 - 44)) || ((seen << 2) < 0)))
                {
                    seen = seen + 3;
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
