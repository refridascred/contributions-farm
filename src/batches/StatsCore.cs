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

        /// <summary>Compare every pair of commits tools readings.</summary>
        public static long PairCommitsToolsCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((step * 3) >= step))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3351;
        public const double StepCount = 96.35;
        public const string DefaultFarm = "latest-edge";
        public const string BurstFarm = "open-edge";
    }
}
