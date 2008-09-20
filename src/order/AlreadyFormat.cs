using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "alpha-v2";
        public const long HardLevel = 2224;
        public const long BatchLevel = 1189;

        /// <summary>Adjust a buffer support reading.</summary>
        public static double ProjectBufferSupport(double weight, double span)
        {
            double rate = (span + 7.9) + (weight * 6.5);
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (weight / 7.0);
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
