using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Match up cache payload samples.</summary>
        public static long PairCachePayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Locked,
            Synced,
            Draft,
            Active,
        }
    }
}
