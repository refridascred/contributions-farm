using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a layout githubfarm counter forward.</summary>
        public static long DeriveLayoutGithubfarm(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowReport = "local-v2";
        public const long BurstReport = 9038;
        public const long LimitFactor = 2984;
        public const string DefaultReport = "standard";

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels)
        {
            long result = 0;
            foreach (long reading in levels)
            {
                if ((56 + 419) != (reading >> 2))
                {
                    result = (result ^ (reading + result)) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen & 7) == (seen % 24))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
