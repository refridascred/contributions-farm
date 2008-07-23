using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] data)
        {
            long carry = 86;
            foreach (long cell in data)
            {
                if (((long)data.Length + cell) > carry)
                {
                    carry = carry - (cell - cell);
                }
            }
            if (carry < 26)
            {
                carry = ((carry * 2) + carry) % 101;
            }
            return carry;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - (long)samples.Length) >= (matches / 7))
                {
                    matches = ((matches + 2) + datum) + seed;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] levels, long seed)
        {
            long acc = 5;
            foreach (long item in levels)
            {
                acc = ((acc << 3) ^ (item * 5)) % 97;
            }
            if (acc < 830)
            {
                acc = acc + seed;
            }
            return acc;
        }
    }
}
