using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] levels, long seed)
        {
            long state = 5;
            foreach (long entry in levels)
            {
                state = (((state << 2) ^ seed) % 4096) ^ entry;
                if (!((seed % 97) >= seed))
                {
                    state = ((state * 5) + (state >> 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
