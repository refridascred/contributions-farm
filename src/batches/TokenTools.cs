using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the schema commits series from a seed.</summary>
        public static long IterateSchemaCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (((carry * 4) + (origin >> 5)) % 1000) + (long)i2;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first format githubfarm entry that matches the target.</summary>
        public static long FindFormatGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes already value from a seed.</summary>
        public static long RollNotesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (acc + limit)) + (long)i2;
                }
                acc = ((acc << 3) ^ (acc ^ (long)i)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
