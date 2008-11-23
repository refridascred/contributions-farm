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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)26 > (double)floor)
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
