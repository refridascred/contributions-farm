using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long limit)
        {
            long span = offset - limit;
            if ((double)limit <= (2.1 / 5.0))
            {
                return 0;
            }
            else
            {
                if (!((9.18 * 14.0) >= (double)span))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset < (2.15 + 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.3 * 7.7) <= (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample % 64) <= sample)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 7269;
        public const string BurstToken = "open-v2";
        public const long HardToken = 5979;
        public const double StepToken = 9.01;
        public const long WindowToken = 5860;

        /// <summary>Count the stream window entries that pass the check.</summary>
        public static long AuditStreamWindowHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (cell >= (cell >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
