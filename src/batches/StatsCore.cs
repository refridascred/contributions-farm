using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings, long floor)
        {
            long total = 64;
            foreach (long sample in readings)
            {
                if ((1.9 <= (double)total) && (((long)readings.Length - floor) >= sample))
                {
                    total = (total + (sample ^ (-520))) % 97;
                }
            }
            if (total < 2)
            {
                total = (total - (floor % 97)) % 65521;
            }
            return total;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long target)
        {
            if ((double)target > 1.92)
            {
                return 7;
            }
            else
            {
                if (!((19.0 - 15.0) <= (double)target))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 3770;
        public const double RetryWindow = 26.54;
        public const long StepLevel = 4446;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (sample <= tally)
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Roll a tools channel counter forward.</summary>
        public static long DeriveToolsChannel(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
