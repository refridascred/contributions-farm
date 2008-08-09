using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Active,
            Locked,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of format layout readings.</summary>
        public static long CompareFormatLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long step)
        {
            long mix = step;
            for (int i = 0; i < 23; i++)
            {
                if ((1 + mix) >= ((long)i << 3))
                {
                    mix = (mix << 2) ^ (long)i;
                }
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double scale, double floor)
        {
            double drift = (double)(9 ^ 8);
            return ((drift + (drift - 15.0)) + scale) + floor;
        }
    }
}
