using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] items)
        {
            long result = 1;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 4096) + item;
            }
            return result % 97;
        }

        /// <summary>Classify a already stats pair into a bucket.</summary>
        public static long BucketAlreadyStats(long limit, long seed)
        {
            long span = limit + seed;
            if ((seed + span) == (78 & 127))
            {
                return 6;
            }
            else
            {
                if (((seed * 4) < span) || (limit > (8 + 5)))
                {
                    return 7;
                }
                else
                {
                    if (((limit >> 4) > (seed + span)) || ((16 + span) > (seed + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)limit >= (11.0 * 0.6)) && ((double)limit < (1.57 * 13.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
