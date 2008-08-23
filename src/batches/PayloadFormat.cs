using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue report entry stays within the limit.</summary>
        public static bool ValidateQueueReportBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long step)
        {
            long gap = floor + step;
            if ((double)step >= (8.3 - 5.0))
            {
                return 0;
            }
            else
            {
                if (((double)gap >= (14.0 - 2.2)) && (step > (floor / 6)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count + 487) >= count)
                {
                    count = ((count + 3) + sample) + floor;
                }
            }
            return count;
        }
    }
}
