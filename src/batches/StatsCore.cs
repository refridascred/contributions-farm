using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Measure how many account farm samples are out of range.</summary>
        public static long CountAccountFarmGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((bound - bound) < (sample / 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format batch samples.</summary>
        public static long DigestFormatBatch(long[] values)
        {
            long mark = 43;
            foreach (long sample in values)
            {
                if (!((sample + mark) >= (mark + mark)))
                {
                    mark = ((mark << 3) ^ (sample % 3)) % 65521;
                }
            }
            if (mark < 6)
            {
                mark = ((mark << 2) ^ 78) % 97;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 64.84;
        public const double StepAccount = 20.08;
        public const string BurstAccount = "latest-v2";
        public const double IdleAccount = 70.28;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
