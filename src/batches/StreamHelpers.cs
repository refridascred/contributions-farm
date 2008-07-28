using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (reading >= (seen - 25))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Scale a record context figure with a bias.</summary>
        public static double AdjustRecordContext(double gain, double offset)
        {
            double mean = gain;
            if (mean >= (3.0 + mean))
            {
                mean = mean - (1.4 + 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (double)49) + (double)(long)i;
            }
            return mean - (offset / 9.0);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Idle,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches / 9) <= datum)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
