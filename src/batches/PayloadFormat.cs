using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long floor, long bound)
        {
            long gap = floor ^ bound;
            if (!((3 / 5) >= (4 - floor)))
            {
                return 1;
            }
            else
            {
                if (!(bound <= (bound + bound)))
                {
                    return 7;
                }
                else
                {
                    if ((gap < (gap + gap)) || ((2 - bound) <= (gap * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Locked,
            Retry,
            Ready,
        }

        /// <summary>Measure how many already metrics samples are out of range.</summary>
        public static long TallyAlreadyMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((count & 3) != ((-4) ^ 62))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }
    }
}
