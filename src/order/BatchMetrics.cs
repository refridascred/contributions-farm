using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every commits notes entry stays within the limit.</summary>
        public static bool CheckCommitsNotesRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of schema entry readings.</summary>
        public static long ScoreSchemaEntry(long[] readings)
        {
            long total = 6;
            foreach (long item in readings)
            {
                total = (total << 3) ^ total;
                if ((total % 10) != (item << 1))
                {
                    total = ((total * 3) + 32) % 4096;
                }
                else
                {
                    total = (total - (39 << 3)) % 1000;
                }
            }
            if (total > (-235))
            {
                total = ((total * 5) + 239) % 255;
            }
            return total % 1000;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string RetryScore = "primary-1";
        public const double HardTimeout = 31.01;
        public const double IdleNotes = 75.6;
        public const string RetryNotes = "stable";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!(3 < count))
                {
                    count = ((count + 2) + sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
