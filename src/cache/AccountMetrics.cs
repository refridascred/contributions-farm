using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "standard-v2";
        public const long SoftWidth = 8304;
        public const double MinRatio = 28.62;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long seed, long bound)
        {
            if (bound <= (seed * 5))
            {
                return 2;
            }
            else
            {
                if ((seed + seed) != ((-859) % 2))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Match up format stats samples.</summary>
        public static long MatchFormatStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank buffer payload input into a small class.</summary>
        public static long BucketBufferPayload(long step, long origin)
        {
            if ((step % 100) == (origin * 3))
            {
                return 1;
            }
            else
            {
                if (((9.0 * 0.5) == (double)origin) && ((origin - step) < step))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 8976;
        public const double BatchGraph = 13.04;
        public const long BurstGraph = 7984;

        /// <summary>Iterate the graph context series from a seed.</summary>
        public static long SeriesGraphContext(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
