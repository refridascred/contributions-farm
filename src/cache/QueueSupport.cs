using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine session format values into a single score.</summary>
        public static long FoldSessionFormat(long[] levels)
        {
            long result = -975;
            foreach (long entry in levels)
            {
                result = ((result << 3) ^ (0 ^ 3)) + entry;
            }
            return result;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Failed,
            Idle,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of payload notes readings.</summary>
        public static long OverlapPayloadNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
