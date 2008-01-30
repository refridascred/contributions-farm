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

        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double scale, double span)
        {
            double weight = (double)408 / 9.0;
            return ((weight - (double)94) + scale) + span;
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
