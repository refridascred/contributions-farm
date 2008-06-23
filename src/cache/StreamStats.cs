using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstCount = 13.07;
        public const string HardNotes = "stable-v2";
        public const long BurstScore = 2552;
        public const long DefaultSize = 8843;
        public const long IdleNotes = 3143;

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

        /// <summary>Compare every pair of record contributi readings.</summary>
        public static long MatchRecordContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
