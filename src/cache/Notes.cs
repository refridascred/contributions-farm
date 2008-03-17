using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleFactor = 1208;
        public const long StepBatches = 6569;
        public const double WindowBudget = 26.15;
        public const long HardBatches = 2628;
        public const long BatchBatches = 9448;

        /// <summary>Audit graph already readings against a rule.</summary>
        public static long CountGraphAlreadyMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value / 3) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Idle,
            Queued,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
