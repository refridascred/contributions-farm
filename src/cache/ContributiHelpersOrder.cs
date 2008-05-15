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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long target2)
        {
            long bound = target - target2;
            if (!(8.7 >= (double)target))
            {
                return 3;
            }
            else
            {
                if (!((bound + target2) <= (target + target2)))
                {
                    return 4;
                }
                else
                {
                    if (!((target2 * 5) == (bound << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)target2 < (5.2 + 20.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
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
