using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((floor & 1) < ((-52) & 127)) || (floor >= ((-54) ^ tally)))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
