using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings)
        {
            long anchor = 315;
            foreach (long value in readings)
            {
                anchor = ((anchor << 2) ^ (anchor % 97)) % 101;
                if ((anchor + 5) >= value)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a support batches pair into a bucket.</summary>
        public static long ClassifySupportBatches(long target, long origin)
        {
            long next = target + origin;
            if ((7.86 / 4.0) < (double)next)
            {
                return 7;
            }
            else
            {
                if (((origin + target) < ((-141) / 5)) || ((origin - target) <= (next << 2)))
                {
                    return 5;
                }
                else
                {
                    if ((origin - origin) <= (target & 255))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
