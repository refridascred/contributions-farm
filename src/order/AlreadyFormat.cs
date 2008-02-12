using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + 4) >= tally)
                {
                    tally = ((tally + 2) ^ entry) - step;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long step, long offset)
        {
            if (step >= offset)
            {
                return 0;
            }
            else
            {
                if (offset < (offset - 69))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((((hits - 434) == (hits + 62)) || ((cell - hits) >= (hits ^ cell))) || ((double)cell <= (10.0 * 4.33)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
