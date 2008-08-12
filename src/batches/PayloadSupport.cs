using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 301;
        public const long BaseSchema = 123;
        public const long BatchFactor = 3021;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((114 + matches) == (origin * 2))
                {
                    matches = (matches + 1) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] values)
        {
            long acc = 842;
            foreach (long item in values)
            {
                if (!((3.0 * 11.0) < (double)acc))
                {
                    acc = ((acc * 2) + (acc + 597)) % 4096;
                }
                else
                {
                    acc = ((acc << 3) ^ ((long)values.Length ^ acc)) % 101;
                }
                if ((item + item) >= 14)
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
