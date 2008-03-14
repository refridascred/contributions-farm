using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long limit)
        {
            long gap = step ^ limit;
            if ((double)limit > (double)gap)
            {
                return 7;
            }
            else
            {
                if ((limit >> 1) != (limit - gap))
                {
                    return 1;
                }
                else
                {
                    if (((-4) / 4) <= (limit * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((8 % 64) == (limit + gap))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
