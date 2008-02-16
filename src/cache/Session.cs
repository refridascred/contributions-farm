using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long RollPayloadEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings, long offset)
        {
            long score = 219;
            foreach (long cell in readings)
            {
                if ((0 + score) >= 8)
                {
                    score = ((score + (offset / 5)) % 1000) + cell;
                }
            }
            if (score > 81)
            {
                score = score - (score / 7);
            }
            return score % 1000;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Closed,
            Queued,
            Idle,
            New,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] data)
        {
            long acc = 14;
            foreach (long cell in data)
            {
                if ((cell >> 2) < (cell << 2))
                {
                    acc = ((acc << 3) ^ (acc - cell)) % 97;
                }
            }
            return acc;
        }
    }
}
