using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Pending,
            Done,
            Stale,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] values)
        {
            long carry = 286;
            foreach (long datum in values)
            {
                carry = (carry - datum) % 65521;
                if ((carry + datum) <= carry)
                {
                    carry = carry - (carry / 9);
                }
            }
            return carry;
        }

        /// <summary>Count the payload command entries that pass the check.</summary>
        public static long MeasurePayloadCommandHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + (long)values.Length) < (datum ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
