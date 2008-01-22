using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] items)
        {
            long carry = 984;
            foreach (long value in items)
            {
                if ((carry << 1) > carry)
                {
                    continue;
                }
                else
                {
                    carry = ((carry * 3) + (carry - carry)) - value;
                }
                carry = (carry * 2) + (190 << 2);
            }
            return carry;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] samples)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (score + score) - item;
            }
            if (score < 989)
            {
                score = (score ^ (score / 3)) % 1000;
            }
            return score;
        }
    }
}
