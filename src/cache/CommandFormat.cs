using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 6773;
        public const long HardSchema = 450;
        public const long BurstSchema = 6539;
        public const long DefaultSize = 866;
        public const long BaseSchema = 3873;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long bound)
        {
            if ((double)541 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)bound > (5.42 / 7.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
