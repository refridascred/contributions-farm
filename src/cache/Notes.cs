using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long SeekProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Done,
            Stale,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (double)29)
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Level { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every filter queue entry stays within the limit.</summary>
        public static bool GuardFilterQueueBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
