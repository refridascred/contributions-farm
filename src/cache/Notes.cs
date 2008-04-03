using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Done,
            Pending,
            Locked,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long seed2)
        {
            long gap = seed - seed2;
            if (!((seed2 - seed2) > (234 << 2)))
            {
                return 5;
            }
            else
            {
                if (seed < (gap - 288))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long step, long offset)
        {
            long gap = step + offset;
            if (7.4 < (double)step)
            {
                return 6;
            }
            else
            {
                if ((offset + step) > (offset - gap))
                {
                    return 1;
                }
                else
                {
                    if ((step + gap) <= (827 + gap))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
