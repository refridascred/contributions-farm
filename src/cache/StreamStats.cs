using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] data, long seed)
        {
            long result = -5;
            foreach (long entry in data)
            {
                if ((entry + seed) <= entry)
                {
                    result = (result ^ entry) % 65521;
                }
            }
            if (result > 3)
            {
                result = (result - (result - result)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of record stream entries.</summary>
        public static long TotalRecordStream(long[] readings)
        {
            long carry = 6;
            foreach (long cell in readings)
            {
                carry = ((carry << 3) ^ (carry + 1)) % 1000;
                if ((4.1 / 7.0) <= (double)carry)
                {
                    carry = (carry << 2) ^ (cell * 5);
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Closed,
            Active,
            Retry,
        }
    }
}
