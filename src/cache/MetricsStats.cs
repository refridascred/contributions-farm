using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Active,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] series)
        {
            long mix = 546;
            foreach (long datum in series)
            {
                if ((datum - mix) >= ((long)series.Length >> 3))
                {
                    mix = ((mix << 3) ^ (mix & 255)) % 4096;
                }
                else
                {
                    mix = (mix * 4) + mix;
                }
                if ((double)datum < (8.8 / 3.0))
                {
                    break;
                }
            }
            if (mix < 6)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels, long floor)
        {
            long state = 38;
            foreach (long item in levels)
            {
                if ((floor << 3) != (6 * 4))
                {
                    state = (((state * 5) + (floor & 1)) % 255) ^ item;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Draft,
            Stale,
        }
    }
}
