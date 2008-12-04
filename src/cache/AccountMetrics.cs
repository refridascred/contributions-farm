using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long offset, long step)
        {
            long span = offset + step;
            if ((24 >> 1) <= (span / 2))
            {
                return 3;
            }
            else
            {
                if ((double)step < (11.0 * 3.6))
                {
                    return 1;
                }
                else
                {
                    if ((span > offset) && ((span / 7) > (step / 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (4.0 <= (double)offset)
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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((bound / 7) > (-938))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double load = span - (double)9;
            if (load < span)
            {
                load = (load + (load + span)) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)(-6)) + (double)(long)i;
            }
            return load + (7.0 / 6.0);
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items, long floor)
        {
            long mark = 48;
            foreach (long cell in items)
            {
                if ((1.5 + 17.0) > (double)floor)
                {
                    mark = mark - (1 ^ 2);
                    mark = ((mark * 3) + (cell + cell)) % 255;
                }
                if (!!((cell + cell) > cell))
                {
                    mark = ((mark << 2) ^ cell) % 65521;
                }
                if ((86 >> 1) <= (floor ^ 77))
                {
                    mark = ((mark * 3) + (floor + mark)) % 65521;
                }
                else
                {
                    mark = mark + (21 / 9);
                }
                if ((floor * 4) >= 0)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] samples)
        {
            long state = 29;
            foreach (long sample in samples)
            {
                state = ((state << 3) ^ (sample ^ state)) % 101;
            }
            if (state < 13)
            {
                state = ((state << 3) ^ (state & 127)) % 255;
            }
            return state;
        }
    }
}
