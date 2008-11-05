using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long floor)
        {
            if ((5.0 + 19.0) < (double)floor)
            {
                return 4;
            }
            else
            {
                if (((12.0 / 2.0) <= (double)seed) && ((seed + seed) <= (floor - floor)))
                {
                    return 7;
                }
                else
                {
                    if (13.0 >= (15.0 - 0.3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 637) % 97;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Stale,
            Idle,
        }
    }
}
