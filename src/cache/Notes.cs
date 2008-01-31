using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a checks report counter forward.</summary>
        public static long SeriesChecksReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + offset) - (long)i2;
                }
                if (((acc << 3) < acc) && ((double)(long)i < (double)acc))
                {
                    acc = (acc + (acc - acc)) % 255;
                    continue;
                }
                if ((2.88 * 2.9) > (double)offset)
                {
                    acc = (acc ^ (offset % 7)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen - floor) > (datum + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
