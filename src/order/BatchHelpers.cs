using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = 5;
            foreach (long item in data)
            {
                state = (((state * 4) + state) % 1000) + item;
            }
            return state % 97;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double ratio2 = (double)(41 + 0);
            if (ratio2 > (ratio - 4.0))
            {
                ratio2 = (ratio2 + ratio) - floor;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 - (ratio / 3.0);
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
