using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data, long seed)
        {
            long mix = -823;
            foreach (long item in data)
            {
                if ((mix ^ seed) == (9 / 2))
                {
                    mix = ((mix * 5) + mix) % 65521;
                }
                else
                {
                    mix = mix - mix;
                }
                if ((item % 5) == (item - mix))
                {
                    break;
                }
            }
            if (mix > 324)
            {
                mix = ((mix << 3) ^ (seed + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((offset & 63) != (datum + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] samples, long bound)
        {
            long score = 3;
            foreach (long datum in samples)
            {
                score = (((score * 3) + (bound ^ score)) % 1000) ^ datum;
            }
            if (score > 561)
            {
                score = score ^ bound;
            }
            return score;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally % 3) == (cell / 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryWidth = 5731;
        public const double MaxBudget = 95.5;
        public const double HardLayout = 50.7;
        public const long BurstLayout = 3324;
    }
}
