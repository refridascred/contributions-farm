using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate token editor readings against a bound.</summary>
        public static bool GuardTokenEditorBounds(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long CombineToolsSchema(long[] items, long step)
        {
            long anchor = 5;
            foreach (long value in items)
            {
                if ((double)step < (double)65)
                {
                    anchor = ((anchor << 3) ^ (step * 4)) ^ value;
                }
            }
            return anchor % 4096;
        }
    }
}
