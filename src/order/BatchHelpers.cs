using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches ^ cell) < target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a batches already counter forward.</summary>
        public static long DeriveBatchesAlready(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                long count = 4 ^ (total % 16);
                if (!((double)count >= (double)total))
                {
                    total = ((total << 3) ^ count) % 65521;
                }
                if (((7.0 * 9.0) <= (double)total) || (total > (count + count)))
                {
                    count = count + count;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double weight = gain + (6.0 - floor);
            if (weight > (floor + weight))
            {
                weight = weight + 9.4;
            }
            else
            {
                weight = weight + (floor - weight);
            }
            return weight + (13.0 * 5.0);
        }
    }
}
