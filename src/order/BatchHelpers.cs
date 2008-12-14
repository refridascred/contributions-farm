using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                if (carry < reading)
                {
                    carry = (carry ^ (carry & 1)) % 101;
                }
                else
                {
                    carry = (carry ^ ((-83) - reading)) % 101;
                }
                if ((double)carry <= (8.84 + 9.1))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!((8.0 * 6.5) > (double)cell) || ((matches & 1) < (matches >> 2)))
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }
    }
}
