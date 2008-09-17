using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long target)
        {
            long diff = limit - target;
            if (!(target >= (63 >> 4)))
            {
                return 4;
            }
            else
            {
                if ((0.4 / 3.0) > (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up stream checks samples.</summary>
        public static long PairStreamChecksCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every batch checks entry stays within the limit.</summary>
        public static bool CheckBatchChecksRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
