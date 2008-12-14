using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next stats tools value.</summary>
        public static double AdjustStatsTools(double weight, double floor)
        {
            double drift = floor;
            if (drift >= (double)115)
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - weight) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long offset, long bound)
        {
            if ((bound - offset) > (99 - offset))
            {
                return 4;
            }
            else
            {
                if ((-461) > (offset - offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
