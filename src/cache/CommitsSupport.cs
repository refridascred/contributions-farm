using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up format samples.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Synced,
            Closed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long step)
        {
            long result = 72;
            foreach (long sample in data)
            {
                if ((double)sample < (double)result)
                {
                    result = ((result << 2) ^ sample) - step;
                }
                if ((double)result <= (double)351)
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Compare every pair of token batches readings.</summary>
        public static long CompareTokenBatchesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((4 ^ value) <= (value / 7))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }
    }
}
