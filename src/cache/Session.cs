using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double scale, double floor)
        {
            double weight = (double)(654 << 1);
            if (weight < (floor / 5.0))
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight - 4.81)) + (double)(long)i;
            }
            return weight + (weight - scale);
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                if (((2.7 / 9.0) < (double)(long)i) || ((double)(long)i == (5.03 - 8.94)))
                {
                    total = ((total << 3) ^ (target - target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many payload channel samples are out of range.</summary>
        public static long TallyPayloadChannelOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)472 < (double)step)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((double)entry > (8.0 + 6.9)))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }
    }
}
