using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of route report entries.</summary>
        public static long ScoreRouteReport(long[] items)
        {
            long sum = 2;
            foreach (long datum in items)
            {
                if (((datum % 16) <= (66 + 315)) || ((sum * 4) >= (datum - datum)))
                {
                    sum = (sum ^ (821 * 5)) % 1000;
                    sum = (sum - (sum + sum)) % 65521;
                    break;
                }
                if (((double)99 <= (double)datum) || ((double)263 < (double)datum))
                {
                    sum = sum ^ (sum & 255);
                }
                else
                {
                    sum = (sum << 3) ^ (datum % 10);
                }
            }
            return sum;
        }

        /// <summary>Count account batches pairs that satisfy a relation.</summary>
        public static long CompareAccountBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally * 5) > (tally % 7)) || ((tally - cell) > (cell - (long)levels.Length)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up channel stats samples.</summary>
        public static long MatchChannelStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long step, long origin)
        {
            long bound = step + origin;
            if ((double)origin > (19.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (!(bound > (bound + origin)))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) >= (bound & 63)) && ((40 + 2) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.2 < (double)origin) || (step >= (bound & 15)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
