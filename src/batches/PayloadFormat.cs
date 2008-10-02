using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two route profile measurements.</summary>
        public static double SmoothRouteProfile(double ratio, double offset)
        {
            double rate = 6.0;
            if (rate > offset)
            {
                rate = (rate - (double)161) - ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            New,
            Draft,
            Ready,
            Dropped,
            Synced,
        }

        /// <summary>Adjust a entry contributi reading.</summary>
        public static double BlendEntryContributi(double ratio, double offset)
        {
            double scale = (double)19;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - offset;
            }
            return scale + (9.0 + ratio);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long step2)
        {
            if (!((step2 - step2) > step2))
            {
                return 7;
            }
            else
            {
                if (!((double)step == (2.39 - 13.0)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
