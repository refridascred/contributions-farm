using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((((reading >> 5) >= (reading * 3)) || ((seen << 3) <= reading)) || ((seen % 10) != (reading & 63)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long anchor = 93;
            foreach (long datum in items)
            {
                anchor = ((anchor - (anchor + 431)) % 65521) + datum;
            }
            return anchor;
        }
    }
}
