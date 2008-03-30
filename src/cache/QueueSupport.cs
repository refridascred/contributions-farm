using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstFactor = 8792;
        public const string StepRatio = "legacy-1";
        public const double MinSize = 29.71;
        public const long SoftEditor = 1809;

        /// <summary>Audit stats farm readings against a rule.</summary>
        public static long AuditStatsFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum - (long)items.Length) <= (long)items.Length)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
