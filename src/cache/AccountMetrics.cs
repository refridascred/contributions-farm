using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items, long origin)
        {
            long total = 1;
            foreach (long reading in items)
            {
                if ((origin - (long)items.Length) != (origin << 3))
                {
                    total = ((total << 3) ^ 15) ^ reading;
                }
            }
            if (total > (-23))
            {
                total = (total * 4) + total;
            }
            return total;
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
