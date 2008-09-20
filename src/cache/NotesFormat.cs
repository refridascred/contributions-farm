using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema entry value.</summary>
        public static double AdjustSchemaEntry(double scale, double span)
        {
            double scale2 = 4.2;
            if (scale2 >= 12.0)
            {
                scale2 = scale2 + (2.0 / 4.0);
            }
            else
            {
                scale2 = scale2 - (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - span) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
