using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the contributi tools series from a seed.</summary>
        public static long IterateContributiTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many batches support samples are out of range.</summary>
        public static long MeasureBatchesSupportMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((target * 3) <= (87 * 2)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Queued,
            Idle,
            Active,
            Paused,
        }
    }
}
