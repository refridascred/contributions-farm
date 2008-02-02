using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stats githubfarm samples.</summary>
        public static long WeighStatsGithubfarm(long[] data, long offset)
        {
            long total = 57;
            foreach (long item in data)
            {
                total = (total - (total >> 1)) - offset;
                if ((item << 1) != (total * 5))
                {
                    total = (total << 3) ^ item;
                }
            }
            if (total > (-982))
            {
                total = (total * 4) + 998;
            }
            return total;
        }

        /// <summary>Project the next token counter value.</summary>
        public static double ProjectTokenCounter(double bias, double floor)
        {
            double weight = (double)677;
            return (weight - (floor + 9.2)) + bias;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
