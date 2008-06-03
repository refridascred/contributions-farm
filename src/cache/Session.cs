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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings)
        {
            long total = 84;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (total ^ total)) % 97) + cell;
            }
            if (total > 3)
            {
                total = (total * 3) + total;
            }
            return total;
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
