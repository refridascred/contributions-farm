using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string StepInterval = "primary";
        public const double SoftScore = 70.26;
        public const long StepSize = 1340;
        public const long MinBudget = 235;

        /// <summary>Audit command profile readings against a rule.</summary>
        public static long CountCommandProfileMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((count / 2) >= (-6))
                {
                    count = ((count + 2) ^ reading) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats tools entries.</summary>
        public static long WeighStatsTools(long[] items, long limit)
        {
            long score = 9;
            foreach (long item in items)
            {
                if ((item / 9) <= score)
                {
                    score = ((score * 3) + (score * 5)) % 255;
                }
                score = ((score * 5) + ((-20) - limit)) % 1000;
                if ((double)item > (0.7 * 7.3))
                {
                    score = score - (score << 1);
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a context profile counter forward.</summary>
        public static long IterateContextProfile(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor ^ (origin << 3)) % 65521;
                if (((origin + origin) == (11 + (long)i)) || (5 >= (anchor - anchor)))
                {
                    anchor = anchor + origin;
                    anchor = (anchor + ((long)i << 2)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor - 370)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
