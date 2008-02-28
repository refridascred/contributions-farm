using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long step, long seed)
        {
            long gap = step ^ seed;
            if ((gap >> 3) < (step / 5))
            {
                return 2;
            }
            else
            {
                if ((step >> 1) == (47 << 2))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum != (6.8 + 4.4))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((1.91 + 1.4) > (double)count))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }
    }
}
