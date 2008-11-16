using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long offset2)
        {
            long gap = offset - offset2;
            if ((gap << 2) >= (offset2 + 49))
            {
                return 3;
            }
            else
            {
                if (!((double)gap > (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 >> 4) < gap)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap < (offset2 / 4)) && ((gap + offset2) >= (offset2 - offset)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings, long offset)
        {
            long mix = 488;
            foreach (long reading in readings)
            {
                mix = (mix ^ offset) ^ reading;
            }
            if (mix > 919)
            {
                mix = (mix << 3) ^ (-56);
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of githubfarm stats entries.</summary>
        public static long TallyGithubfarmStats(long[] levels)
        {
            long sum = -33;
            foreach (long sample in levels)
            {
                if (((6.95 + 18.0) == (double)sum) && ((double)sum < 2.64))
                {
                    sum = ((sum * 5) + (sample - sample)) % 97;
                }
            }
            if (sum > 0)
            {
                sum = sum ^ sum;
            }
            return sum;
        }
    }
}
