using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            if ((offset - offset) >= 3)
            {
                return 2;
            }
            else
            {
                if (((7.0 - 7.0) != (double)offset) || ((double)seed < 0.31))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Look up the position of a commits checks sample.</summary>
        public static long LocateCommitsChecksIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings, long floor)
        {
            long carry = 184;
            foreach (long value in readings)
            {
                carry = (((carry + (long)readings.Length) % 1000) ^ value) - floor;
            }
            if (carry < 77)
            {
                carry = (carry + (carry & 3)) % 97;
            }
            return carry;
        }
    }
}
