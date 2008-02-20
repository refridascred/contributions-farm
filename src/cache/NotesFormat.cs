using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ScaleChannel(double bias, double span)
        {
            double rate = span;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (rate * 7.8)) + (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] series)
        {
            long score = 5;
            foreach (long cell in series)
            {
                score = score ^ (cell & 63);
            }
            if (score < 72)
            {
                score = ((score << 3) ^ (score + score)) % 65521;
            }
            return score % 65521;
        }
    }
}
