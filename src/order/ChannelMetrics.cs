using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally & 63) > (tally >> 2))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Combine layout counter values into a single score.</summary>
        public static long WeighLayoutCounter(long[] levels)
        {
            long mix = 4;
            foreach (long value in levels)
            {
                if ((mix % 12) < 400)
                {
                    mix = ((mix << 2) ^ value) % 97;
                    mix = (mix - (mix + value)) % 1000;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix % 10)) % 255;
                }
                mix = ((mix * 5) + mix) % 4096;
            }
            return mix;
        }
    }
}
