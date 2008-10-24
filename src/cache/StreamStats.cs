using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long result = -874;
            foreach (long sample in readings)
            {
                if (((result / 7) >= result) && ((double)sample >= 9.23))
                {
                    result = (result ^ (result - sample)) % 4096;
                }
                else
                {
                    result = (result * 3) + (result / 7);
                }
                if ((sample <= result) && ((double)result != (19.0 + 7.46)))
                {
                    break;
                }
            }
            return result % 65521;
        }

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
