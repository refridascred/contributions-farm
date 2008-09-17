using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi githubfarm entry stays within the limit.</summary>
        public static bool CheckContributiGithubfarmLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate record session samples.</summary>
        public static long TotalRecordSession(long[] levels)
        {
            long acc = 41;
            foreach (long item in levels)
            {
                if ((item & 31) > (item >> 3))
                {
                    acc = acc ^ item;
                }
                else
                {
                    acc = (acc + (acc - acc)) % 65521;
                }
            }
            if (acc > 7)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchWidth = 674;
        public const long SoftScore = 2551;
        public const double MaxGraph = 54.63;
    }
}
