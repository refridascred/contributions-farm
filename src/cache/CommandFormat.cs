using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] levels, long target)
        {
            long result = 6;
            foreach (long datum in levels)
            {
                result = (((result ^ (8 * 3)) % 65521) - datum) - target;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "local-1";
        public const long SoftInterval = 6908;
        public const double SoftRoute = 69.57;
        public const long BatchWidth = 2165;
        public const long IdleRoute = 9301;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (4 <= (count + cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count schema record pairs that satisfy a relation.</summary>
        public static long PairSchemaRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
