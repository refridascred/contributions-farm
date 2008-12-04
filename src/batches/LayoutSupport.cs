using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank layout queue input into a small class.</summary>
        public static long SortLayoutQueue(long offset, long floor)
        {
            if ((8 * 4) <= (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((20.0 * 10.0) <= (double)offset)
                {
                    return 4;
                }
                else
                {
                    if (floor <= (offset / 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 60) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Stale,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item > (item + matches)) || ((item + item) > (item % 2)))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepSize = 8023;
        public const long BaseEntry = 431;
        public const string IdleTimeout = "staging-edge";
        public const long DefaultEntry = 8925;
        public const string SoftEntry = "open-edge";
    }
}
