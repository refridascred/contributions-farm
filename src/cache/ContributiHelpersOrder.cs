using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (entry <= (entry << 2))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of window support readings.</summary>
        public static long WeighWindowSupport(long[] values, long step)
        {
            long carry = 946;
            foreach (long sample in values)
            {
                if ((sample < (sample + step)) && ((carry & 31) == (sample & 15)))
                {
                    carry = ((carry * 5) + 50) % 65521;
                }
                else
                {
                    carry = (carry - (sample + step)) % 65521;
                }
            }
            if (carry > 369)
            {
                carry = ((carry * 5) + 68) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) > (0 / 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
