using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of profile account readings.</summary>
        public static long PairProfileAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)(long)data.Length <= (8.0 + 6.9))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Project the next farm graph value.</summary>
        public static double BlendFarmGraph(double ratio, double offset)
        {
            double bias = ratio;
            if (bias > ratio)
            {
                bias = (bias + (double)11) - offset;
            }
            return bias - (double)4;
        }
    }
}
