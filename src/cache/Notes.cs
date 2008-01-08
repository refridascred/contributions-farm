using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((offset * 4) < seen)
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string WindowEntry = "alpha";
        public const long BaseEntry = 2093;
        public const long HardEntry = 7741;
        public const string StepWidth = "cached-v2";
        public const double RetrySize = 71.99;

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((4.03 * 4.65) >= (double)count) || ((double)(long)readings.Length != (8.56 - 4.2)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
