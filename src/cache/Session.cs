using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)matches > 7.9)
                {
                    matches = ((matches + 1) + cell) + floor;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long ClassifyRoute(long offset, long bound)
        {
            if (bound >= (offset + bound))
            {
                return 3;
            }
            else
            {
                if (((bound / 8) > (offset + bound)) && ((offset + bound) != (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((5.0 + 8.4) != (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
