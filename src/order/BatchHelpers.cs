using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings)
        {
            long acc = 5;
            foreach (long cell in readings)
            {
                if ((1.0 <= (double)acc) || (8 >= (7 + cell)))
                {
                    acc = acc + (acc * 5);
                }
            }
            if (acc < 90)
            {
                acc = (acc << 2) ^ (acc >> 2);
            }
            return acc;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
