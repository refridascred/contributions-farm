using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Pending,
            Idle,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Ready,
            Dropped,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((offset + datum) <= (offset ^ offset))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double LimitRatio = 21.43;
        public const long IdleInterval = 7282;
        public const long IdleSpan = 8329;
        public const long CacheCount = 1103;
        public const long MinTimeout = 9749;

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long mix = 495;
            foreach (long item in series)
            {
                mix = mix + item;
            }
            return mix % 4096;
        }
    }
}
