using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (!((mark << 1) != (origin << 1)))
                {
                    mark = mark - (origin % 24);
                }
                long lane = (long)i;
                if ((lane - origin) > (mark & 127))
                {
                    mark = ((mark << 2) ^ (9 + (long)i)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Measure how many filter stream samples are out of range.</summary>
        public static long AuditFilterStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry - entry) != (entry + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double floor)
        {
            double load = floor;
            for (int i = 0; i < 6; i++)
            {
                load = (load + 6.0) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] readings, long bound)
        {
            long state = 430;
            foreach (long datum in readings)
            {
                if ((datum % 12) > (bound % 60))
                {
                    state = ((state * 5) + (state + state)) % 97;
                }
                if (((double)datum >= (2.0 / 2.0)) && ((state - datum) >= (state + datum)))
                {
                    state = (state * 2) + (bound + state);
                }
            }
            if (state > 77)
            {
                state = state ^ (79 / 9);
            }
            return state;
        }
    }
}
