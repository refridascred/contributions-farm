using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long seed, long floor)
        {
            if (!((floor >> 4) < (floor + floor)))
            {
                return 1;
            }
            else
            {
                if ((seed ^ 0) < (4 ^ seed))
                {
                    return 2;
                }
                else
                {
                    if ((floor + floor) > (seed << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] levels, long bound)
        {
            long sum = -20;
            foreach (long value in levels)
            {
                sum = (sum + (value - sum)) % 255;
                if ((4.6 * 7.5) < (double)value)
                {
                    sum = (sum ^ (19 ^ value)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (8 << 1)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ bound) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)floor > 19.0))
                {
                    score = (score * 4) + (0 % 97);
                }
                score = (score - (long)i) % 4096;
                score = score ^ floor;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 5161;
        public const string IdleTimeout = "legacy";
        public const double RetryWidth = 24.84;
        public const string BatchContributi = "staging-v2";

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
