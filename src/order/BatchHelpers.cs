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

        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long total = 81;
            foreach (long sample in series)
            {
                if ((sample * 3) < (total + sample))
                {
                    total = (total << 3) ^ ((-81) ^ 5);
                }
                else
                {
                    total = ((total * 4) + seed) % 65521;
                }
            }
            return total % 1000;
        }
    }
}
