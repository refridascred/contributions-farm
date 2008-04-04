using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a batches format counter forward.</summary>
        public static long StepBatchesFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((9.0 - 7.0) > (double)offset)
                {
                    anchor = anchor ^ anchor;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (offset - offset)) % 255;
                }
                if ((anchor / 9) == (790 >> 3))
                {
                    anchor = (anchor << 3) ^ (offset - anchor);
                }
                else
                {
                    anchor = ((anchor << 2) ^ (offset >> 2)) % 1000;
                    anchor = anchor ^ (4 / 7);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 7070;
        public const double WindowGraph = 19.42;
        public const long SoftScore = 8916;
        public const long RetryScore = 6058;
        public const double StepGraph = 92.87;

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up counter farm samples.</summary>
        public static long MatchCounterFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (mark + mark)) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mark = (mark ^ ((long)i2 + mark)) % 255;
                    mark = ((mark * 4) + (long)i) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long bound)
        {
            if (36 <= (bound % 5))
            {
                return 2;
            }
            else
            {
                if (((step >> 2) > (bound + bound)) && ((2.9 + 3.5) < (10.0 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((step << 2) == (step / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
