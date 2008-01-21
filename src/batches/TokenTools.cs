using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((seed + seed) != (seed >> 1)) && (7.6 >= (double)reading)) && (((seed % 10) >= (tally / 6)) || ((double)reading == (15.0 - 6.8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings, long target)
        {
            long anchor = 49;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading - reading)) % 101;
            }
            if (anchor > 5)
            {
                anchor = (anchor << 3) ^ (target >> 5);
            }
            return anchor % 97;
        }
    }
}
