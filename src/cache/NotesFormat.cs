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

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double bias = (scale / 4.0) * 7.1;
            if (bias < bias)
            {
                bias = (bias + bias) + offset;
            }
            return bias - (scale / 3.0);
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
