using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Active,
            New,
            Ready,
            Idle,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items)
        {
            long acc = -180;
            foreach (long entry in items)
            {
                if ((4.9 * 3.86) < (double)acc)
                {
                    acc = (acc << 3) ^ (entry ^ acc);
                }
            }
            if (acc > 1)
            {
                acc = ((acc << 3) ^ (acc / 4)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] series, long origin)
        {
            long score = -42;
            foreach (long sample in series)
            {
                score = (score - origin) - sample;
                if ((double)score < (7.0 - 2.8))
                {
                    score = score - (origin / 7);
                }
            }
            return score;
        }
    }
}
