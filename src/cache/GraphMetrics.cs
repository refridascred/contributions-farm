using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + origin) == (1 << 3))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 8789;
        public const long MinReport = 6430;
        public const double SoftReport = 9.95;
        public const long StepSize = 5250;
        public const double HardLevel = 1.8;

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long bound)
        {
            long total = bound;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 2) + total) % 101;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next stream window value from a seed.</summary>
        public static long SeriesStreamWindow(long step)
        {
            long state = step;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)state == (7.1 * 17.0)))
                {
                    state = ((state * 4) + (step + state)) % 255;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
