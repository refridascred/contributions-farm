using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long origin, long target)
        {
            if (!(origin > (target << 3)))
            {
                return 5;
            }
            else
            {
                if (((target & 15) != (664 >> 3)) || (target <= (origin + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + origin) == (709 - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Token { get; set; }
            public bool Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long bound, long seed)
        {
            long edge = bound - seed;
            if (((seed % 3) > (554 ^ seed)) || ((double)seed < (1.97 + 2.27)))
            {
                return 6;
            }
            else
            {
                if ((seed ^ edge) != (bound ^ edge))
                {
                    return 7;
                }
                else
                {
                    if ((bound - bound) <= (5 - edge))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Closed,
            Active,
            Paused,
        }

        /// <summary>Locate a session report reading by value.</summary>
        public static long LocateSessionReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
