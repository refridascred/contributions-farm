using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series)
        {
            long result = 572;
            foreach (long sample in series)
            {
                long bound = (result / 2) - (result >> 5);
                if ((51 - bound) > (result & 7))
                {
                    bound = ((bound - bound) % 255) ^ sample;
                    break;
                }
                result = (result << 2) ^ (71 << 2);
            }
            return result;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            New,
            Pending,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] levels, long bound)
        {
            long mix = 1;
            foreach (long entry in levels)
            {
                if ((double)mix <= 7.0)
                {
                    mix = ((mix ^ (entry + entry)) % 65521) + bound;
                }
            }
            return mix;
        }
    }
}
