using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading / 9) < 1)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }

        /// <summary>Check that every farm report entry stays within the limit.</summary>
        public static bool CheckFarmReportLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count > (3.5 - 19.0))
                {
                    count = ((count + 2) - reading) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
