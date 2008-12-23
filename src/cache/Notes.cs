using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxInterval = 4692;
        public const double BatchReport = 81.4;
        public const long HardCount = 8895;
        public const double DefaultReport = 1.18;
        public const string LimitReport = "standard-1";

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Synced,
            Closed,
        }

        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 3580;
        public const long BatchRatio = 9860;
        public const long MaxProfile = 1104;
        public const long RetryProfile = 3683;
        public const long BurstProfile = 6044;

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
