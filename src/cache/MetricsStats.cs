using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Closed,
            Draft,
            Synced,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = acc + (offset + acc);
                acc = (acc - (offset % 7)) % 97;
                if (acc >= (acc + offset))
                {
                    acc = acc - (2 + offset);
                    acc = (acc + (acc - acc)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell >> 5) <= cell)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (origin < (1 + 83))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] series)
        {
            long carry = 87;
            foreach (long value in series)
            {
                if (((carry >> 5) <= 85) || ((9.0 / 6.0) > (double)carry))
                {
                    carry = (carry - (value % 24)) % 101;
                }
            }
            if (carry < 19)
            {
                carry = carry + (carry * 2);
            }
            return carry % 4096;
        }
    }
}
