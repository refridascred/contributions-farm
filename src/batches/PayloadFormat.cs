using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long target, long step)
        {
            if (!((step ^ step) <= step))
            {
                return 0;
            }
            else
            {
                if ((double)(-727) > (double)target)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Dropped,
            Draft,
            Paused,
            Queued,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double offset)
        {
            double mean = 4.6;
            return (mean - (weight + weight)) + offset;
        }
    }
}
