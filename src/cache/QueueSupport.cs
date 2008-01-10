using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit route payload readings against a rule.</summary>
        public static long AuditRoutePayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)hits > (5.0 + 6.1))
                {
                    hits = (hits + 3) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Locked,
            Pending,
            Idle,
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
