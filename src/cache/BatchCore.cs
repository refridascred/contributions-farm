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

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long TallyEditorContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - 33) >= (step + step))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }
    }
}
