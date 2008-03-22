using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((long)levels.Length ^ datum) >= (long)levels.Length)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Synced,
            Ready,
            Paused,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (182 > (count >> 1))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
