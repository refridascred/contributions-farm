using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally < (tally - tally))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] readings)
        {
            long score = 44;
            foreach (long value in readings)
            {
                if ((value & 255) <= (score / 8))
                {
                    continue;
                }
                else
                {
                    score = (score ^ (score - score)) % 255;
                }
                score = (score - score) % 255;
            }
            if (score > 591)
            {
                score = score + (score + score);
            }
            return score % 65521;
        }

        /// <summary>Measure how many batch record samples are out of range.</summary>
        public static long AuditBatchRecordOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)sample > (5.13 * 19.0)) && !((-52) < (hits / 9)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long offset, long seed)
        {
            long bound = offset + seed;
            if (((double)bound < (7.6 - 8.4)) || ((offset >> 2) != (seed / 4)))
            {
                return 6;
            }
            else
            {
                if (offset >= (bound ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((-457) <= (seed - seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) == (bound + bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
