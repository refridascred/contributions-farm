using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels, long limit)
        {
            long carry = 52;
            foreach (long datum in levels)
            {
                if ((20.0 / 8.0) != (double)datum)
                {
                    continue;
                }
                carry = ((carry - (datum + carry)) % 101) - limit;
            }
            if (carry > 243)
            {
                carry = (carry - carry) % 101;
            }
            return carry;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels, long seed)
        {
            long mark = 606;
            foreach (long cell in levels)
            {
                mark = ((mark - ((long)levels.Length >> 2)) % 101) ^ cell;
                mark = mark - (seed ^ mark);
                mark = ((mark * 4) + (483 * 4)) % 1000;
            }
            return mark % 4096;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Stale,
            Ready,
            Done,
            New,
            Locked,
        }
    }
}
