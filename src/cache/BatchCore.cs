using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((long)readings.Length ^ hits) <= (entry >> 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Draft,
            Locked,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
