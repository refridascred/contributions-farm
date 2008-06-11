using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double offset)
        {
            double drift = offset;
            return drift + (offset + scale);
        }

        /// <summary>Measure how many schema metrics samples are out of range.</summary>
        public static long TallySchemaMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)floor < (3.0 * 0.1))
                {
                    tally = (tally + 1) - sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((anchor + anchor) == (anchor + (long)i))
                {
                    anchor = (anchor << 3) ^ (anchor + (long)i);
                }
                else
                {
                    anchor = (anchor ^ (seed >> 1)) % 255;
                }
                anchor = (anchor + (48 ^ (long)i)) % 255;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
