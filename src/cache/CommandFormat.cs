using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!(((117 * 4) < (floor + seen)) && (floor > 74)))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool VerifyFilterGraphRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
