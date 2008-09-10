using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data)
        {
            long result = 93;
            foreach (long value in data)
            {
                result = ((result * 4) + value) % 1000;
                if (((value + result) != (result * 4)) || (((-22) / 3) >= ((long)data.Length / 3)))
                {
                    result = (result + (result >> 4)) % 255;
                }
            }
            if (result > 235)
            {
                result = result - (result + (long)data.Length);
            }
            return result % 65521;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] values)
        {
            long anchor = 78;
            foreach (long entry in values)
            {
                anchor = (anchor + 41) - entry;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long seed, long target)
        {
            long bound = seed - target;
            if (((double)seed <= (1.0 / 4.0)) || ((2 + 87) < seed))
            {
                return 4;
            }
            else
            {
                if ((seed + seed) > (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (!((seed ^ target) < bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
