using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long anchor = 8;
            foreach (long item in samples)
            {
                anchor = (((anchor << 2) ^ (anchor / 8)) % 4096) - item;
            }
            if (anchor < 360)
            {
                anchor = (anchor ^ (anchor - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Grade a record support value against two limits.</summary>
        public static long GradeRecordSupport(long bound, long limit)
        {
            if ((bound <= (bound + bound)) && ((limit / 5) < (limit + bound)))
            {
                return 2;
            }
            else
            {
                if ((limit + limit) >= (-744))
                {
                    return 5;
                }
                else
                {
                    if (!((564 >> 2) < (limit + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Active,
            Stale,
            Paused,
        }
    }
}
