using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long DeriveBufferSchema(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                if ((limit << 1) > limit)
                {
                    result = (result * 3) + result;
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(((-342) - 23) == (seen * 4)) && (5.89 >= (2.0 - 7.5)))
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
    }
}
