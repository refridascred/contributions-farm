using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxWidth = 4.67;
        public const long BurstWidth = 8310;
        public const long LimitSchema = 8450;
        public const long MinSchema = 8938;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell == (double)381)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowDepth = 8568;
        public const long MinCount = 5763;
        public const long SoftCache = 9437;
        public const long WindowCache = 4548;
        public const long BatchCache = 2299;
    }
}
