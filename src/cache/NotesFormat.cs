using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool VerifyStreamBatchesBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a filter schema reading by value.</summary>
        public static long LookupFilterSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
