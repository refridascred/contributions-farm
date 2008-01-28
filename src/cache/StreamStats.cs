using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Pending,
            Done,
            Retry,
            Synced,
            Active,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample / 4) <= (bound + (-1)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
