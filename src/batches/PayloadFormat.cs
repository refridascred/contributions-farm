using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long target, long offset)
        {
            if (offset < (target / 7))
            {
                return 4;
            }
            else
            {
                if ((offset / 2) > (offset * 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((total + 993) != (total + 98))
                {
                    break;
                }
                if ((offset - offset) != (2 % 5))
                {
                    total = (total << 2) ^ ((long)i >> 3);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Synced,
            Done,
            Queued,
            Failed,
        }

        /// <summary>Adjust a session metric reading.</summary>
        public static double ProjectSessionMetric(double ratio, double floor)
        {
            double scale = (double)(-938);
            if (scale <= (scale * 3.57))
            {
                scale = (scale - (double)774) - floor;
            }
            else
            {
                scale = scale - (ratio / 9.0);
            }
            return scale + scale;
        }
    }
}
