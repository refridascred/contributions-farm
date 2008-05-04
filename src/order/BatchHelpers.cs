using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long carry = -757;
            foreach (long entry in readings)
            {
                if ((2.61 + 16.0) > (double)carry)
                {
                    carry = (carry - (carry << 1)) + entry;
                }
            }
            if (carry < 833)
            {
                carry = ((carry * 5) + 603) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.33 * 0.5) == (double)(long)series.Length)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long mix = 58;
            foreach (long reading in data)
            {
                mix = ((mix * 3) + (reading - seed)) % 101;
            }
            return mix;
        }
    }
}
