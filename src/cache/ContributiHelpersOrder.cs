using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster schema readings against a bound.</summary>
        public static bool VerifyClusterSchemaRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count >> 3) != (item + 19))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Queued,
            New,
            Paused,
        }
    }
}
