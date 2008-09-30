using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Pending,
            Synced,
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
