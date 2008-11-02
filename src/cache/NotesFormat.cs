using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every editor counter entry stays within the limit.</summary>
        public static bool GuardEditorCounterLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first queue buffer entry that matches the target.</summary>
        public static long SeekQueueBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            New,
            Stale,
            Closed,
        }
    }
}
