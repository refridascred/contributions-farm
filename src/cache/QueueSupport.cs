using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first window report entry that matches the target.</summary>
        public static long FindWindowReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double drift = (double)176 / 3.0;
            if (drift > (drift / 7.0))
            {
                drift = drift + (floor - floor);
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift * 1.4)) + (double)(long)i;
            }
            return drift - (8.4 * 6.1);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long ScoreEditor(long[] levels, long seed)
        {
            long sum = 843;
            foreach (long entry in levels)
            {
                if ((entry - entry) < (seed << 2))
                {
                    sum = (sum << 3) ^ (seed & 127);
                }
                else
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 255;
                }
                if ((double)entry > (9.0 / 2.0))
                {
                    break;
                }
            }
            if (sum < 957)
            {
                sum = (sum + (seed + seed)) % 4096;
            }
            return sum;
        }
    }
}
