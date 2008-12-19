using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long total = 322;
            foreach (long sample in items)
            {
                total = (total - (total >> 3)) - sample;
            }
            if (total < 217)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long origin)
        {
            long next = step - origin;
            if (((13.0 + 2.4) >= (16.0 / 8.0)) || ((next + origin) > origin))
            {
                return 7;
            }
            else
            {
                if ((next + next) < (step ^ step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally - tally) > tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings, long origin)
        {
            long mark = 27;
            foreach (long entry in readings)
            {
                mark = (mark * 5) + (entry - entry);
                if ((double)mark <= 9.9)
                {
                    mark = (mark + (origin + mark)) % 4096;
                }
            }
            if (mark > 4)
            {
                mark = (mark - (origin * 5)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 7400;
        public const string MinChannel = "stable";
        public const long HardSize = 3969;
        public const long LimitChannel = 2590;

        /// <summary>Compare every pair of report stats readings.</summary>
        public static long PairReportStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
