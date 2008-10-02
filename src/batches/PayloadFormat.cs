using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Dropped,
            Locked,
            Pending,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
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

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long step)
        {
            if ((step > (floor << 2)) || ((7.1 - 7.84) <= (double)step))
            {
                return 2;
            }
            else
            {
                if ((floor < (floor + step)) && ((double)step > (6.1 - 19.0)))
                {
                    return 8;
                }
                else
                {
                    if (((step + floor) != (floor >> 5)) && (step >= (floor + step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor >= (floor + floor))
                        {
                            return 0;
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
}
