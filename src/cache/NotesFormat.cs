using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double gain, double offset)
        {
            double ratio = (double)(734 + 0);
            return ((ratio + 1.3) + gain) + offset;
        }

        /// <summary>Find the first batch session entry that matches the target.</summary>
        public static long LookupBatchSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public string Region { get; set; } = "";
            public double Offset { get; set; }
            public double Stamp { get; set; }
            public long Total { get; set; }
        }
    }
}
