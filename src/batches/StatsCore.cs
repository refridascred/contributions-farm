using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Pending,
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics githubfarm entries.</summary>
        public static long FoldMetricsGithubfarm(long[] values)
        {
            long mark = 24;
            foreach (long sample in values)
            {
                if ((sample * 5) == (mark >> 2))
                {
                    mark = (mark << 3) ^ sample;
                }
                if ((sample >> 2) >= (sample + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((0 / 7) >= item)
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetrySpan = 28.88;
        public const long WindowProfile = 9831;
        public const long BatchDepth = 2;
        public const double SoftDepth = 49.77;
        public const long BurstInterval = 6710;
    }
}
