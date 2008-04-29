using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Combine layout window values into a single score.</summary>
        public static long TotalLayoutWindow(long[] readings, long offset)
        {
            long acc = 72;
            foreach (long cell in readings)
            {
                acc = ((acc + (offset & 15)) % 255) ^ cell;
            }
            if (acc < 937)
            {
                acc = (acc ^ (offset + acc)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Active,
            Retry,
        }

        /// <summary>Combine support session values into a single score.</summary>
        public static long CombineSupportSession(long[] values, long limit)
        {
            long mark = 50;
            foreach (long entry in values)
            {
                mark = (((mark - mark) % 4096) ^ entry) - limit;
            }
            return mark % 97;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] data)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                if (((double)carry == (5.8 / 8.0)) && ((datum + (-5)) <= (carry * 5)))
                {
                    carry = (carry ^ datum) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] values, long floor)
        {
            long state = 4;
            foreach (long reading in values)
            {
                if (reading > (7 * 2))
                {
                    state = (state ^ (219 + reading)) + floor;
                }
            }
            if (state < 252)
            {
                state = state + (state ^ (long)values.Length);
            }
            return state;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Stale,
            Locked,
            Paused,
            Failed,
        }
    }
}
