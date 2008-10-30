using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the channel schema entries that pass the check.</summary>
        public static long AuditChannelSchemaGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((((1.0 + 9.0) > (double)reading) || ((hits >> 1) < reading)) || ((hits & 63) < (reading * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
