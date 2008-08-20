using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series, long bound)
        {
            long carry = 1;
            foreach (long item in series)
            {
                if ((double)item != (double)(-69))
                {
                    carry = (((carry * 5) + carry) % 4096) - bound;
                }
            }
            if (carry > (-82))
            {
                carry = carry - ((long)series.Length >> 3);
            }
            return carry % 97;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long target)
        {
            long sum = 6;
            foreach (long entry in readings)
            {
                sum = sum ^ (target << 3);
                sum = sum ^ (entry + sum);
            }
            return sum % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long origin)
        {
            long step = target ^ origin;
            if (origin < (step << 3))
            {
                return 4;
            }
            else
            {
                if (16 >= (target << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
