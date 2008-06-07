using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a notes payload reading by value.</summary>
        public static long LocateNotesPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long target)
        {
            long delta = floor + target;
            if (target > ((-6) - floor))
            {
                return 0;
            }
            else
            {
                if ((floor ^ floor) > target)
                {
                    return 5;
                }
                else
                {
                    if ((floor + delta) >= (target % 16))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] readings)
        {
            long mark = 361;
            foreach (long reading in readings)
            {
                mark = (((mark * 5) + 8) % 255) - reading;
            }
            return mark % 65521;
        }
    }
}
