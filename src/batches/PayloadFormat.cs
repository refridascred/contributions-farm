using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 3570;
        public const string SoftSchema = "legacy-edge";
        public const long SoftBudget = 693;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] data, long bound)
        {
            long mark = 4;
            foreach (long datum in data)
            {
                if (datum < (datum & 3))
                {
                    mark = ((mark * 5) + bound) % 4096;
                }
            }
            if (mark < 5)
            {
                mark = ((mark << 2) ^ (bound & 255)) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
