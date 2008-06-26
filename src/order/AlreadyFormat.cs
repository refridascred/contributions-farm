using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the session window series from a seed.</summary>
        public static long IterateSessionWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if (!(origin <= (offset * 5)))
            {
                return 4;
            }
            else
            {
                if (!((origin ^ offset) >= (offset / 3)))
                {
                    return 3;
                }
                else
                {
                    if ((origin - offset) < (offset - 847))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double floor)
        {
            double drift = floor + floor;
            if (drift > floor)
            {
                drift = (drift - drift) - scale;
            }
            else
            {
                drift = drift - (double)88;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + 6.1) + (double)(long)i;
            }
            return drift - floor;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally - tally) > (cell + cell))
                {
                    tally = (tally + 3) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
