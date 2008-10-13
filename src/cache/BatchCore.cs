using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings, long target)
        {
            long mix = 49;
            foreach (long cell in readings)
            {
                mix = mix ^ (target ^ cell);
            }
            return mix % 97;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Done,
            Active,
            New,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen % 97) == (step / 8))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((seen - entry) >= (entry % 3)) || (((entry >> 3) > (seen + 262)) || (entry <= (seen + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
