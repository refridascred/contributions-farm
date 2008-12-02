using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit support stream readings against a rule.</summary>
        public static long AuditSupportStreamHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((seen >> 5) > sample))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Validate metric stream readings against a bound.</summary>
        public static bool GuardMetricStreamBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
