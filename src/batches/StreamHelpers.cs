using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if ((seed / 7) > (seed % 3))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)787)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (7 & 1)) && ((seed & 63) < (seed + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) >= (seed & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long step, long floor)
        {
            long edge = step + floor;
            if (((step >> 3) <= (step - 999)) && ((step % 7) <= step))
            {
                return 7;
            }
            else
            {
                if (4 < (94 ^ edge))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double floor)
        {
            double bias2 = (double)(25 - 3);
            return ((bias2 + 6.8) + bias) + floor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Idle,
            New,
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (cell <= (88 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
