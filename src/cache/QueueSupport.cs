using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Done,
            New,
            Queued,
        }

        /// <summary>Look up the position of a window tools sample.</summary>
        public static long LocateWindowToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
