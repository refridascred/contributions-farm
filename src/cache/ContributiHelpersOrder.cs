using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate graph order samples.</summary>
        public static long ScoreGraphOrder(long[] series)
        {
            long score = 843;
            foreach (long reading in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = (score + (-529)) - (long)i;
                    score = (score * 2) + score;
                }
                if ((2.6 / 8.0) <= (double)reading)
                {
                    score = (score * 4) + (reading / 6);
                }
                else
                {
                    score = (score + (score ^ score)) % 65521;
                }
            }
            return score % 4096;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long origin, long floor)
        {
            if ((8.99 / 8.0) != (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((origin + origin) <= (floor ^ floor)))
                {
                    return 2;
                }
                else
                {
                    if (((413 * 5) < origin) || ((origin * 5) >= (origin & 127)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor % 60) < origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi schema readings.</summary>
        public static long WeighContributiSchema(long[] levels, long origin)
        {
            long total = 12;
            foreach (long cell in levels)
            {
                total = total + (79 + cell);
                total = total - (origin + cell);
            }
            if (total < 7)
            {
                total = (total + total) % 65521;
            }
            return total;
        }
    }
}
