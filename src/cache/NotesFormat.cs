using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] samples, long target)
        {
            long acc = 63;
            foreach (long datum in samples)
            {
                acc = (acc + (target << 1)) % 4096;
                if ((acc * 5) >= (target * 5))
                {
                    acc = (acc - ((long)samples.Length + datum)) % 4096;
                }
            }
            if (acc > (-99))
            {
                acc = ((acc * 4) + target) % 255;
            }
            return acc;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!(sample <= (sample ^ seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
