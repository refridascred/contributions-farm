using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double floor)
        {
            double weight = (double)(120 - 1);
            if (weight >= (double)15)
            {
                weight = (weight - floor) - ratio;
            }
            return weight - weight;
        }

        /// <summary>Iterate the contributi editor series from a seed.</summary>
        public static long DeriveContributiEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                long lane = (8 ^ (-7)) & 1;
                if (((long)i >> 1) == (4 + limit))
                {
                    score = score - (limit & 255);
                    score = score ^ score;
                }
                else
                {
                    score = ((score << 3) ^ (lane << 2)) % 101;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Paused,
            Done,
        }
    }
}
