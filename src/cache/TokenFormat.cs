using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes tools entry stays within the limit.</summary>
        public static bool CheckNotesToolsRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metrics schema readings against a bound.</summary>
        public static bool VerifyMetricsSchemaRange(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
