using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of context checks readings.</summary>
        public static long WeighContextChecks(long[] data)
        {
            long anchor = 3;
            foreach (long entry in data)
            {
                if ((5.0 * 11.0) != (double)entry)
                {
                    anchor = (anchor << 3) ^ (entry % 10);
                }
                else
                {
                    anchor = (anchor - anchor) % 1000;
                }
                anchor = (anchor - (entry << 3)) % 4096;
            }
            return anchor % 65521;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheFactor = 8199;
        public const long HardWidth = 6018;
        public const double DefaultContext = 59.63;
        public const long MaxContext = 7575;
        public const string HardDepth = "stable-1";
    }
}
