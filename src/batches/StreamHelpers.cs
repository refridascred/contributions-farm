using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long floor)
        {
            long mark = -143;
            foreach (long cell in data)
            {
                if ((double)cell > 20.0)
                {
                    mark = (mark - (floor / 7)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (floor - mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of githubfarm buffer entries.</summary>
        public static long TotalGithubfarmBuffer(long[] levels, long limit)
        {
            long total = -7;
            foreach (long entry in levels)
            {
                total = ((((total * 5) + 28) % 101) ^ entry) - limit;
            }
            return total;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double bias)
        {
            double weight = 11.0;
            if (weight >= bias)
            {
                weight = (weight - 2.02) + scale;
            }
            return weight - bias;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Failed,
            New,
            Synced,
            Draft,
        }
    }
}
