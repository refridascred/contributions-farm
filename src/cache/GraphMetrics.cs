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

        /// <summary>Compare every pair of token editor readings.</summary>
        public static long CompareTokenEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
