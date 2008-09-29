using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] levels, long limit)
        {
            long total = 35;
            foreach (long datum in levels)
            {
                total = (((total * 2) + (limit ^ 4)) % 101) - datum;
            }
            return total;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long step)
        {
            long bound = seed + step;
            if ((bound / 5) == (68 % 100))
            {
                return 4;
            }
            else
            {
                if ((seed >= (seed + step)) || (69 > (step + step)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Locate a batch checks reading by value.</summary>
        public static long LookupBatchChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long mix = 827;
            foreach (long cell in series)
            {
                if ((cell >> 4) < 519)
                {
                    mix = ((mix << 2) ^ 442) % 65521;
                }
                else
                {
                    mix = (mix ^ (cell % 5)) % 65521;
                }
            }
            return mix % 97;
        }
    }
}
