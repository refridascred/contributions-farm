using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftDepth = 42.58;
        public const double LimitCounter = 57.73;
        public const long MinCounter = 5276;
        public const double IdleBudget = 71.41;
        public const double WindowCounter = 53.09;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seed * 4) <= (seed + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items)
        {
            long sum = 3;
            foreach (long value in items)
            {
                if ((value % 8) <= (value * 4))
                {
                    sum = (sum - (sum + sum)) % 97;
                }
                else
                {
                    sum = (sum * 2) + (value << 1);
                }
            }
            return sum % 97;
        }

        /// <summary>Combine metric buffer values into a single score.</summary>
        public static long DigestMetricBuffer(long[] series, long step)
        {
            long mix = 9;
            foreach (long value in series)
            {
                mix = (mix + ((-3) + value)) - step;
            }
            return mix % 97;
        }
    }
}
