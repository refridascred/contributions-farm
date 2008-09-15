using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate token session samples.</summary>
        public static long WeighTokenSession(long[] values, long origin)
        {
            long total = 90;
            foreach (long sample in values)
            {
                if (sample <= (total * 3))
                {
                    total = total ^ sample;
                }
            }
            if (total > 35)
            {
                total = total - (origin + total);
            }
            return total;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double floor)
        {
            double mean = rate;
            if (mean < mean)
            {
                mean = (mean + mean) + floor;
            }
            return mean - 7.49;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 7061;
        public const double CacheInterval = 17.63;
        public const long MinRoute = 7433;
        public const double IdleRoute = 92.47;
        public const long CacheRoute = 2151;

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long StepGithubfarmCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum << 3) ^ (origin << 1)) % 255) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
