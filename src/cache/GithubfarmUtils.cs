using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] levels)
        {
            long sum = 5;
            foreach (long sample in levels)
            {
                if (((sample >> 5) < (193 / 5)) || ((sample + sample) <= (sum + sample)))
                {
                    sum = ((sum << 3) ^ (sum >> 5)) % 255;
                }
                if (7 > (sum & 255))
                {
                    break;
                }
            }
            return sum;
        }

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
