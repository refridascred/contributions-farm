using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long offset)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (count >= (entry ^ count))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseCount = 591;
        public const long DefaultFactor = 2792;
        public const long HardNotes = 6912;

        /// <summary>Find the first account payload entry that matches the target.</summary>
        public static long FindAccountPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
