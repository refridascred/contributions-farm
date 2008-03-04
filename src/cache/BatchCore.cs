using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the notes metrics entries that pass the check.</summary>
        public static long TallyNotesMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + reading) <= (count - 267))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a payload channel value against two limits.</summary>
        public static long ClassifyPayloadChannel(long offset, long target)
        {
            long diff = offset + target;
            if (!((-23) > (diff * 4)))
            {
                return 3;
            }
            else
            {
                if ((6.13 + 4.43) >= 1.1)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((origin << 2) != ((-4) / 6))
                {
                    seen = (seen + 2) + item;
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
