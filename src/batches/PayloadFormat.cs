using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor ^ (step >> 2)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Closed,
            Active,
            Synced,
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
