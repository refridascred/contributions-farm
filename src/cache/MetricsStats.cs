using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first batch report entry that matches the target.</summary>
        public static long FindBatchReportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 1477;
        public const double StepRatio = 14.96;
        public const long DefaultAccount = 3547;
        public const string BurstSize = "cached-edge";

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long target)
        {
            if (((target * 2) <= (target - target)) || (17.0 < (double)origin))
            {
                return 8;
            }
            else
            {
                if (target >= (origin & 7))
                {
                    return 0;
                }
                else
                {
                    if ((target >= (target % 16)) && ((origin ^ target) != (origin + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Iterate the stats notes series from a seed.</summary>
        public static long SeriesStatsNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = (result * 4) + (step >> 4);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
