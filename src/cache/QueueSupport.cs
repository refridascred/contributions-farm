using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] items, long seed)
        {
            long total = 669;
            foreach (long datum in items)
            {
                if (!((double)total < (18.0 + 16.0)))
                {
                    total = (total ^ total) - seed;
                }
                total = total - datum;
            }
            if (total > 9)
            {
                total = (total - 978) % 97;
            }
            return total % 65521;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length + 385) >= entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Stale,
            Active,
            Closed,
            Idle,
            Done,
        }
    }
}
