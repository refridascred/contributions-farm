using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 2.76;
        public const double MaxDepth = 36.38;
        public const long HardFarm = 9526;
        public const double DefaultFarm = 36.04;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((long)readings.Length ^ cell) < cell) && ((2.95 / 8.0) != (double)cell))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format metrics series from a seed.</summary>
        public static long RollFormatMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum + (offset ^ sum)) % 65521;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
