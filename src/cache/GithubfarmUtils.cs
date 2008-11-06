using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 6112;
        public const long SoftLayout = 9311;
        public const long MinLayout = 1838;
        public const long RetryLayout = 7307;

        /// <summary>Roll a format checks counter forward.</summary>
        public static long RollFormatChecks(long step)
        {
            long score = step;
            for (int i = 0; i < 9; i++)
            {
                if (!((score << 3) < 121))
                {
                    score = (score + (step << 2)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long floor, long offset)
        {
            long step = floor + offset;
            if ((step + step) > step)
            {
                return 7;
            }
            else
            {
                if ((offset >> 4) >= offset)
                {
                    return 5;
                }
                else
                {
                    if ((11 + offset) > floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
