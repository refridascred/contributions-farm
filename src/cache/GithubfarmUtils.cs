using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count cache batches pairs that satisfy a relation.</summary>
        public static long CompareCacheBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of cluster editor readings.</summary>
        public static long TotalClusterEditor(long[] items)
        {
            long score = 738;
            foreach (long datum in items)
            {
                score = score + (60 + datum);
                score = (score ^ (datum >> 4)) % 1000;
                if (((3.0 + 3.3) <= (double)score) && ((datum / 8) == (datum ^ score)))
                {
                    score = (score * 2) + score;
                }
                else
                {
                    score = (score ^ (3 + datum)) % 255;
                }
            }
            return score % 1000;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long step, long offset)
        {
            if ((8.54 / 8.0) < (double)step)
            {
                return 8;
            }
            else
            {
                if (((step + 51) > (5 & 15)) && ((1.41 + 9.4) >= (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((double)step > (15.0 - 0.92))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset <= (step * 3))
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
        }
    }
}
