using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 424;
        public const long BatchStream = 906;
        public const string BurstDepth = "stable-edge";
        public const string MaxDepth = "cached-edge";
        public const double LimitSpan = 51.09;

        /// <summary>Fold a list of session schema readings.</summary>
        public static long WeighSessionSchema(long[] readings, long origin)
        {
            long acc = 14;
            foreach (long value in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = (acc - origin) - (long)i;
                }
                acc = acc - (value + acc);
            }
            if (acc > 538)
            {
                acc = (acc + (-4)) % 255;
            }
            return acc;
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches / 3) > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
