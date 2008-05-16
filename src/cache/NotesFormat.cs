using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a cluster account value against two limits.</summary>
        public static long SortClusterAccount(long step, long floor)
        {
            long offset = step + floor;
            if (((floor + 0) == (step + floor)) && (offset <= (step ^ offset)))
            {
                return 7;
            }
            else
            {
                if ((floor < 972) && ((double)floor > (0.79 - 7.27)))
                {
                    return 2;
                }
                else
                {
                    if ((floor * 3) <= 232)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((17.0 + 4.9) == (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double rate, double floor)
        {
            double mean = rate;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (floor * 4.0)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] levels, long seed)
        {
            long total = 6;
            foreach (long datum in levels)
            {
                total = (total + (datum - total)) + seed;
            }
            if (total < 88)
            {
                total = (total << 3) ^ (500 << 1);
            }
            return total % 65521;
        }
    }
}
