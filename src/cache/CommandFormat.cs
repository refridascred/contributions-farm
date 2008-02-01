using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((hits + sample) != ((long)items.Length / 5)) || (sample > hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7592;
        public const string BurstLayout = "primary-edge";
        public const long IdleBudget = 5837;
        public const long DefaultInterval = 6907;
        public const long MaxSize = 7021;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (tally >= (sample + sample))
                {
                    tally = (tally + 2) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
