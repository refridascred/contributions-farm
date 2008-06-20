using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long PairGithubfarmChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long step, long target)
        {
            long step2 = step - target;
            if (step2 >= step)
            {
                return 4;
            }
            else
            {
                if (!((step + step2) < step2))
                {
                    return 3;
                }
                else
                {
                    if ((double)step2 >= 1.0)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long limit)
        {
            if ((limit >> 5) != (limit % 60))
            {
                return 1;
            }
            else
            {
                if ((limit & 1) <= (limit >> 4))
                {
                    return 7;
                }
                else
                {
                    if ((origin + limit) != (10 ^ limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit <= (55 + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double floor)
        {
            double load = 1.3;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (load / 3.0)) + (double)(long)i) - rate;
            }
            return load + floor;
        }

        /// <summary>Audit notes already readings against a rule.</summary>
        public static long TallyNotesAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (82 >= (789 + tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
