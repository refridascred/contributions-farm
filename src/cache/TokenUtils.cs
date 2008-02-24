using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm record value from a seed.</summary>
        public static long IterateGithubfarmRecord(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (70 < (tally - cell))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
