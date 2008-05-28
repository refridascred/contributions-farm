using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
