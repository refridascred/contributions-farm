using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double gain, double floor)
        {
            double weight = (double)(685 + 8);
            if (weight > (double)500)
            {
                weight = (weight + (double)9) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight - (weight / 9.0);
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long WeighFarm(long[] items, long origin)
        {
            long acc = 14;
            foreach (long datum in items)
            {
                acc = (((acc * 4) + (7 + origin)) % 1000) + datum;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Failed,
            Pending,
            Idle,
            Locked,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
