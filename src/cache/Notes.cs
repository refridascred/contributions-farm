using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long sum = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (((sum * 2) + (sum ^ 88)) % 255) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((double)165 <= (double)floor)
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout cluster entry stays within the limit.</summary>
        public static bool ValidateLayoutClusterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxTimeout = 5948;
        public const long MaxWidth = 2138;
        public const long IdleGraph = 6378;

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((floor & 31) < floor) && ((matches >> 5) >= matches))
                {
                    matches = (matches + 1) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
