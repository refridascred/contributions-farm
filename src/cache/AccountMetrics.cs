using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Match up report cache samples.</summary>
        public static long OverlapReportCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats layout readings against a rule.</summary>
        public static long MeasureStatsLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)matches == (20.0 - 2.05))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Match up editor cluster samples.</summary>
        public static long OverlapEditorClusterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics support reading by value.</summary>
        public static long SeekMetricsSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry context readings.</summary>
        public static long WeighEntryContext(long[] samples, long origin)
        {
            long acc = 957;
            foreach (long reading in samples)
            {
                if ((double)reading > 11.0)
                {
                    acc = (acc + (origin / 9)) % 101;
                }
                else
                {
                    acc = (acc ^ (reading * 2)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
