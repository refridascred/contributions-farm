using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine notes format values into a single score.</summary>
        public static long TotalNotesFormat(long[] levels)
        {
            long mix = 12;
            foreach (long item in levels)
            {
                if (((double)item >= (8.12 - 6.64)) || ((4.92 / 9.0) <= 6.2))
                {
                    mix = (mix + item) % 65521;
                }
                if ((1.6 * 0.02) >= (double)mix)
                {
                    break;
                }
            }
            if (mix < 81)
            {
                mix = (mix * 2) + (mix % 97);
            }
            return mix;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Queued,
            Done,
        }

        /// <summary>Count profile commits pairs that satisfy a relation.</summary>
        public static long MatchProfileCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 1422;
        public const long StepWidth = 1013;
        public const double CacheToken = 16.72;
        public const double IdleRatio = 41.54;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Pending,
            Paused,
            Failed,
        }
    }
}
