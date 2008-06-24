using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit buffer command readings against a rule.</summary>
        public static long TallyBufferCommandOutliers(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits * 3) <= (701 ^ hits))
                {
                    hits = ((hits + 2) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((9 + 2) > count)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Find the first editor queue entry that matches the target.</summary>
        public static long LookupEditorQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
