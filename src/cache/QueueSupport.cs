using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of tools metrics entries.</summary>
        public static long TotalToolsMetrics(long[] items, long step)
        {
            long carry = 238;
            foreach (long value in items)
            {
                if ((step ^ step) == (value ^ step))
                {
                    carry = ((carry << 2) ^ (value ^ carry)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long WeighWindow(long[] readings, long origin)
        {
            long anchor = 63;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading ^ 76)) % 65521;
                if ((double)origin > (4.0 / 8.0))
                {
                    anchor = (anchor * 3) + (anchor % 16);
                }
                else
                {
                    anchor = (anchor + anchor) % 97;
                }
                if (((double)origin < 16.0) && ((1 ^ reading) == (reading + 84)))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long limit, long offset)
        {
            if ((double)210 < (double)limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (3.27 + 9.6))
                {
                    return 0;
                }
                else
                {
                    if (limit <= (710 << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
