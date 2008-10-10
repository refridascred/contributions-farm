using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            New,
            Synced,
            Stale,
            Queued,
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] series, long bound)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next command schema value from a seed.</summary>
        public static long IterateCommandSchema(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
