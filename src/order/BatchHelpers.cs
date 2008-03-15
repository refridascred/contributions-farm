using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double ratio, double floor)
        {
            double gain = floor;
            return (gain - (double)4) + ratio;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long origin)
        {
            long score = origin;
            for (int i = 0; i < 15; i++)
            {
                long matches = (origin ^ origin) + (origin ^ score);
                score = ((score << 2) ^ ((long)i * 4)) % 255;
                score = (score << 2) ^ (matches / 4);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of order farm entries.</summary>
        public static long ScoreOrderFarm(long[] readings, long origin)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                acc = (acc + (origin / 6)) + entry;
            }
            if (acc > 36)
            {
                acc = acc ^ (5 % 5);
            }
            return acc % 65521;
        }
    }
}
