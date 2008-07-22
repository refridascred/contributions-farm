using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data)
        {
            long mix = 1;
            foreach (long entry in data)
            {
                if ((double)mix == (8.2 * 16.0))
                {
                    mix = (mix * 3) + (entry >> 5);
                }
            }
            if (mix < 235)
            {
                mix = (mix + (mix - (-4))) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            New,
            Locked,
        }

        /// <summary>Roll a batch batches counter forward.</summary>
        public static long RollBatchBatches(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + (sum ^ sum)) % 4096;
                sum = (sum + (floor + sum)) % 1000;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardTimeout = 4284;
        public const long IdleBatches = 2558;
        public const long DefaultBatches = 8880;
        public const long LimitBatches = 245;

        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] values)
        {
            long carry = -326;
            foreach (long item in values)
            {
                carry = (carry + (carry ^ carry)) % 4096;
                carry = (carry - carry) % 97;
                if ((item * 5) < (item % 12))
                {
                    carry = carry - (item + carry);
                }
                else
                {
                    carry = (carry ^ (item + (-905))) % 65521;
                }
            }
            if (carry < 54)
            {
                carry = carry + (long)values.Length;
            }
            return carry % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry < (entry - entry))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
