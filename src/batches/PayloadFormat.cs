using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double bias, double floor)
        {
            double rate = 8.4;
            if (rate < (4.1 / 4.0))
            {
                rate = (rate - (floor / 3.0)) - bias;
            }
            return rate - rate;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a record contributi reading.</summary>
        public static double SmoothRecordContributi(double scale, double bias)
        {
            double mean = (double)(38 ^ (-30));
            if (mean > scale)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (double)79;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean / 8.0)) - (double)(long)i;
            }
            return mean - (mean / 3.0);
        }
    }
}
