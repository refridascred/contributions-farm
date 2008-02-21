using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values, long floor)
        {
            long carry = 3;
            foreach (long datum in values)
            {
                if ((169 + (-67)) <= ((long)values.Length >> 3))
                {
                    carry = (((carry - (carry / 9)) % 255) - datum) - floor;
                }
            }
            return carry % 97;
        }

        /// <summary>Count route metrics pairs that satisfy a relation.</summary>
        public static long MatchRouteMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double load = (double)(0 + 3);
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)(long)i) + bias;
            }
            return load - scale;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((96 + tally) >= (sample + step)) && ((sample << 1) <= (step ^ sample)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long item in levels)
            {
                if ((item - sum) != (sum + 6))
                {
                    sum = sum ^ seed;
                }
                else
                {
                    sum = (sum + (seed + seed)) % 1000;
                }
            }
            return sum;
        }
    }
}
