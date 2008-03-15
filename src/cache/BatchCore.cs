using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long bound)
        {
            if ((5 ^ floor) >= (floor - floor))
            {
                return 1;
            }
            else
            {
                if ((9 + floor) > ((-51) + (-601)))
                {
                    return 4;
                }
                else
                {
                    if (810 < (30 + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (floor <= (floor >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Active,
            Failed,
            Ready,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen >= ((long)data.Length / 5)) || ((seen / 6) < (item % 12)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
