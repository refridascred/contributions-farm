using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Pending,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
