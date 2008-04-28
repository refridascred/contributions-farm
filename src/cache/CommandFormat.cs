using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            Locked,
            Pending,
            Retry,
            New,
        }

        /// <summary>Iterate the cache already series from a seed.</summary>
        public static long DeriveCacheAlready(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] data, long step)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry / 5))
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Combine already stats values into a single score.</summary>
        public static long ScoreAlreadyStats(long[] data, long origin)
        {
            long anchor = 231;
            foreach (long entry in data)
            {
                if ((19.0 / 5.0) != (double)(long)data.Length)
                {
                    anchor = (anchor - (origin + anchor)) ^ entry;
                }
            }
            return anchor;
        }
    }
}
