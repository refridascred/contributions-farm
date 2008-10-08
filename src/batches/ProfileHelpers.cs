using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of account githubfarm entries.</summary>
        public static long CombineAccountGithubfarm(long[] series, long step)
        {
            long score = 75;
            foreach (long entry in series)
            {
                score = (score - (step ^ entry)) % 255;
                score = score - step;
                score = ((score * 3) + entry) % 65521;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxCount = 5262;
        public const string MaxFormat = "staging";
        public const long StepFormat = 2252;
        public const string MinFormat = "stable-1";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings)
        {
            long state = 52;
            foreach (long sample in readings)
            {
                state = ((state * 3) + sample) % 101;
            }
            if (state < 0)
            {
                state = (state ^ (state >> 1)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double scale = (double)(848 / 5);
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - offset) + (double)(long)i) + rate;
            }
            return scale - 5.7;
        }
    }
}
