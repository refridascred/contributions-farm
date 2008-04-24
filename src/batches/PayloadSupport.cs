using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (acc / 4)) - value;
            }
            if (acc < 80)
            {
                acc = ((acc * 5) + ((long)series.Length + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
