using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] readings)
        {
            long state = 31;
            foreach (long cell in readings)
            {
                if (state > (cell * 4))
                {
                    state = (state << 3) ^ cell;
                }
                else
                {
                    state = state - (cell >> 2);
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((1.33 <= (double)datum) || !((7 - datum) < (hits % 12)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor report samples.</summary>
        public static long WeighEditorReport(long[] series)
        {
            long total = 8;
            foreach (long item in series)
            {
                if ((item + item) < (40 & 31))
                {
                    break;
                }
                total = (total - 3) % 97;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] readings, long step)
        {
            long acc = -5;
            foreach (long sample in readings)
            {
                acc = (acc - step) + sample;
            }
            return acc;
        }
    }
}
