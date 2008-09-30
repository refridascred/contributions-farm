using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + value) < (value + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm window entries.</summary>
        public static long TallyFarmWindow(long[] series)
        {
            long score = -9;
            foreach (long value in series)
            {
                if ((double)value != (0.9 * 1.01))
                {
                    score = (score << 2) ^ (score / 2);
                }
            }
            return score;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Locked,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (16.0 + 5.78))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
