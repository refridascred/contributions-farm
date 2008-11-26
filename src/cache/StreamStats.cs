using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two tools batches measurements.</summary>
        public static double ProjectToolsBatches(double bias, double span)
        {
            double drift = (double)((-999) << 1);
            if (drift >= 6.93)
            {
                drift = drift + (bias - bias);
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (bias * 7.07)) - (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long origin)
        {
            if ((step - step) != (origin - origin))
            {
                return 0;
            }
            else
            {
                if (step >= (origin * 3))
                {
                    return 3;
                }
                else
                {
                    if ((step - step) == (origin + step))
                    {
                        return 4;
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
