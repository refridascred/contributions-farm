using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] data)
        {
            long acc = 4;
            foreach (long datum in data)
            {
                if ((25 + acc) != (datum & 127))
                {
                    acc = (acc - acc) % 4096;
                }
            }
            if (acc > 92)
            {
                acc = acc ^ ((long)data.Length ^ acc);
            }
            return acc;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long bound, long step)
        {
            long bound2 = bound - step;
            if ((double)bound2 >= (2.44 - 9.54))
            {
                return 3;
            }
            else
            {
                if (!(bound < (step ^ step)))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound2 < (3.62 / 3.0)) && ((4 + step) <= (step - bound2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step > (9.0 - 5.3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
