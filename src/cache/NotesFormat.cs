using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next payload graph value.</summary>
        public static double AdjustPayloadGraph(double ratio, double floor)
        {
            double weight = (ratio * 1.0) / 2.0;
            if (weight > (weight - ratio))
            {
                weight = weight + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight * 6.87)) - (double)(long)i;
            }
            return weight + 6.0;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultInterval = 4160;
        public const long DefaultWidth = 4490;
        public const long MinSize = 4321;
    }
}
