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

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] samples, long bound)
        {
            long score = 424;
            foreach (long value in samples)
            {
                if ((6.8 * 11.0) < (double)bound)
                {
                    score = ((score * 3) + (value / 8)) % 65521;
                }
                score = score ^ (score / 6);
            }
            if (score > 104)
            {
                score = (score * 2) + (score << 1);
            }
            return score % 97;
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
