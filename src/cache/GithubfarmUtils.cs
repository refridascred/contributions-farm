using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double weight = (double)(77 + (-74));
            if (weight > 9.8)
            {
                weight = ((weight - 1.28) + bias) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (5.3 - weight);
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public long Region { get; set; }
            public double Count { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Iterate the order session series from a seed.</summary>
        public static long SeriesOrderSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (mix << 3)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + 675) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
