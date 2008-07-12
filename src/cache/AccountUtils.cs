using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((bound + reading) > 12) && (550 > bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next schema notes value from a seed.</summary>
        public static long DeriveSchemaNotes(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long offset = floor - 2;
                    mix = ((mix << 3) ^ offset) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
