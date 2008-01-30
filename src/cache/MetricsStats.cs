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

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels, long offset)
        {
            long state = 87;
            foreach (long datum in levels)
            {
                if ((double)state == (6.8 - 6.0))
                {
                    state = (state - datum) % 101;
                }
                else
                {
                    state = (state << 3) ^ (datum << 3);
                }
                if ((237 + 0) >= (offset * 3))
                {
                    break;
                }
            }
            if (state < 1)
            {
                state = (state - (offset - state)) % 101;
            }
            return state;
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
