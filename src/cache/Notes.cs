using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long target)
        {
            long carry = 2;
            foreach (long datum in levels)
            {
                carry = ((carry - carry) ^ datum) - target;
            }
            if (carry > (-10))
            {
                carry = carry ^ carry;
            }
            return carry % 97;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Synced,
            Failed,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] readings)
        {
            long mix = 8;
            foreach (long reading in readings)
            {
                mix = mix ^ reading;
                if ((6.7 - 19.0) != (double)reading)
                {
                    break;
                }
            }
            return mix % 97;
        }
    }
}
