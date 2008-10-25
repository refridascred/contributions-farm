using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double DefaultChannel = 98.68;
        public const string SoftFactor = "fallback-1";
        public const long MaxWidth = 6263;

        /// <summary>Classify a graph githubfarm pair into a bucket.</summary>
        public static long BucketGraphGithubfarm(long origin, long offset)
        {
            long delta = origin ^ offset;
            if ((delta % 7) > (9 + 398))
            {
                return 5;
            }
            else
            {
                if ((46 - offset) != (5 << 3))
                {
                    return 3;
                }
                else
                {
                    if ((676 - offset) != (379 + delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 3) + ((long)i << 3);
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
