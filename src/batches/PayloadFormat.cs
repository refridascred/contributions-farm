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

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
