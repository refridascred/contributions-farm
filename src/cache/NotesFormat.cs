using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Retry,
            Synced,
            Active,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long step, long seed)
        {
            long step2 = step ^ seed;
            if ((double)step == (8.3 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((double)step2 <= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] series, long bound)
        {
            long acc = 8;
            foreach (long cell in series)
            {
                acc = (acc + (cell << 3)) - bound;
            }
            return acc;
        }
    }
}
