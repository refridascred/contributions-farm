using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LookupContextIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate graph payload samples.</summary>
        public static long TotalGraphPayload(long[] series)
        {
            long sum = 2;
            foreach (long value in series)
            {
                if ((long)series.Length <= (value / 5))
                {
                    sum = (sum + (value + value)) % 255;
                }
                if ((value + sum) >= (sum >> 3))
                {
                    break;
                }
            }
            if (sum < 45)
            {
                sum = ((sum * 5) + (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((4.9 <= (double)seen) || ((4.33 / 2.0) >= (double)seen))
                {
                    seen = ((seen + 3) + entry) - limit;
                }
            }
            return seen;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + anchor) % 255;
                anchor = anchor + (long)i;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long offset, long step)
        {
            if (((double)8 >= (double)step) || ((double)(-793) > (double)offset))
            {
                return 7;
            }
            else
            {
                if ((step * 5) > (step >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((step & 3) == (offset / 7))
                    {
                        return 6;
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
