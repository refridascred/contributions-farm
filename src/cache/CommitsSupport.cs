using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 9107;
        public const long BurstSchema = 8928;
        public const long HardSchema = 6422;
        public const long BatchSchema = 955;

        /// <summary>Measure how many record account samples are out of range.</summary>
        public static long CountRecordAccountOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step <= (count % 16))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings)
        {
            long total = 717;
            foreach (long entry in readings)
            {
                if ((entry - total) < 849)
                {
                    total = (total - (total * 4)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a metrics batch sample.</summary>
        public static long LocateMetricsBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double gain, double floor)
        {
            double ratio = (gain - gain) / 6.0;
            return (ratio - ratio) + floor;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Synced,
            Dropped,
            Closed,
        }
    }
}
