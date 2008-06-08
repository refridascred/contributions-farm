using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long seed)
        {
            if ((216 - offset) > (offset + seed))
            {
                return 0;
            }
            else
            {
                if (((double)offset != (6.6 - 12.0)) && ((seed ^ offset) == (offset % 100)))
                {
                    return 3;
                }
                else
                {
                    if (!(seed >= (seed >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
