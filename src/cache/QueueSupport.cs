using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset - sum) != (offset & 15))
                {
                    sum = ((sum * 2) + sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of farm batch readings.</summary>
        public static long ScoreFarmBatch(long[] samples)
        {
            long carry = 97;
            foreach (long datum in samples)
            {
                carry = carry + (carry + datum);
                carry = (carry ^ datum) % 4096;
                carry = carry + (386 << 1);
            }
            return carry % 65521;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }
    }
}
