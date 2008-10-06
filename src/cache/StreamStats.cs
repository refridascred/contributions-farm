using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] series, long offset)
        {
            long sum = 78;
            foreach (long entry in series)
            {
                if (offset <= (offset % 8))
                {
                    sum = (((sum << 3) ^ (sum - 6)) % 101) + entry;
                }
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Pending,
            Paused,
            Locked,
        }
    }
}
