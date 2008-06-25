using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Idle,
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long seed)
        {
            long carry = 51;
            foreach (long reading in values)
            {
                if (((reading - carry) <= (carry & 127)) && ((carry + 36) >= 97))
                {
                    carry = ((carry - (73 + carry)) % 255) - seed;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                }
            }
            return carry % 97;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((acc >> 5) > (acc * 4))
                {
                    acc = (acc ^ (acc + 6)) % 97;
                    acc = acc - (long)i;
                }
                acc = acc - (acc ^ target);
                if ((target + (long)i) > (acc - (long)i))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
