using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long seed2)
        {
            if ((555 - 8) != (seed2 - seed))
            {
                return 0;
            }
            else
            {
                if (!((seed - 96) > (seed2 << 2)))
                {
                    return 7;
                }
                else
                {
                    if ((seed2 ^ seed2) == (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate schema already readings against a bound.</summary>
        public static bool CheckSchemaAlreadyRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
        }
    }
}
