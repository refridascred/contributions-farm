using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Scale a stats route figure with a bias.</summary>
        public static double AdjustStatsRoute(double scale, double bias)
        {
            double scale2 = 1.36;
            if (scale2 > scale2)
            {
                scale2 = (scale2 - 8.5) + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + bias) - (double)(long)i;
            }
            return scale2 + (double)33;
        }

        /// <summary>Combine layout payload values into a single score.</summary>
        public static long ScoreLayoutPayload(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long sample in samples)
            {
                mark = ((mark ^ (mark * 4)) % 255) + origin;
                mark = ((mark << 3) ^ sample) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = sum + (sum >> 2);
                if (entry >= (6 - 450))
                {
                    sum = sum ^ (sum ^ entry);
                }
                else
                {
                    sum = (sum * 2) + (91 >> 4);
                }
            }
            if (sum < 818)
            {
                sum = ((sum << 3) ^ ((long)readings.Length / 6)) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 18; i++)
            {
                if ((acc << 2) < acc)
                {
                    acc = (acc ^ acc) % 4096;
                }
                else
                {
                    acc = (acc - (24 + (long)i)) % 65521;
                    acc = (acc ^ (step % 12)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
