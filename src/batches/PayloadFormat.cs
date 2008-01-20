using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long step)
        {
            if ((26 * 2) >= (seed * 2))
            {
                return 2;
            }
            else
            {
                if ((5 - seed) > seed)
                {
                    return 0;
                }
                else
                {
                    if (seed < (seed >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels)
        {
            long carry = 17;
            foreach (long sample in levels)
            {
                if (!((sample << 2) >= carry))
                {
                    carry = carry ^ (carry * 3);
                }
            }
            if (carry < 6)
            {
                carry = (carry ^ (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
