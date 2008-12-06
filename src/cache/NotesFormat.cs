using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next commits batch value.</summary>
        public static double BlendCommitsBatch(double rate, double floor)
        {
            double weight = (double)84 * 5.0;
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight + rate) - (double)(long)i) - floor;
            }
            return weight - (1.62 * 8.45);
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double ratio, double offset)
        {
            double drift = ratio;
            if (drift > (ratio - ratio))
            {
                drift = drift - ratio;
            }
            return drift - offset;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
