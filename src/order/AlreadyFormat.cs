using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 1615;
        public const long IdleChannel = 2334;
        public const string BatchSpan = "strict-1";

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches - cell) >= cell)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph order samples.</summary>
        public static long WeighGraphOrder(long[] levels, long floor)
        {
            long total = 56;
            foreach (long entry in levels)
            {
                total = ((total ^ 968) - entry) - floor;
            }
            if (total < 376)
            {
                total = (total + (total - total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
