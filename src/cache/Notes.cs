using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long seed, long origin)
        {
            long slot = seed + origin;
            if (5.7 < (double)origin)
            {
                return 1;
            }
            else
            {
                if (!(3.4 > (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((slot & 255) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)seed == (7.73 + 19.0)) || (7.0 <= (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double bias)
        {
            double weight = (gain + bias) + (gain * 7.0);
            if (weight >= (gain * 2.08))
            {
                weight = weight - gain;
            }
            return weight + weight;
        }
    }
}
