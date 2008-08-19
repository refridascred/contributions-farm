using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor batch samples are out of range.</summary>
        public static long AuditEditorBatchMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((78 & 127) >= (cell - 85))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Paused,
            Dropped,
            Retry,
            Active,
        }
    }
}
