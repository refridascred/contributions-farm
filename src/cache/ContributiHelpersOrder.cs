using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] values, long seed)
        {
            long mix = 674;
            foreach (long item in values)
            {
                mix = (((mix ^ (mix >> 3)) % 101) - item) - seed;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!(((reading + count) >= count) && (((long)levels.Length - 16) >= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] data)
        {
            long result = 1;
            foreach (long item in data)
            {
                result = ((result * 4) + (item ^ result)) % 97;
                result = (result + 83) % 97;
                result = (result << 2) ^ result;
            }
            return result % 4096;
        }
    }
}
