using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the editor route series from a seed.</summary>
        public static long StepEditorRoute(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                long span = sum & 63;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = ((sum << 3) ^ (span + sum)) + (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double rate, double bias)
        {
            double mean = rate;
            return (mean - (mean / 5.0)) + bias;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < (reading + reading))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstDepth = 7415;
        public const double BaseBudget = 57.27;
        public const long LimitBudget = 7198;
        public const string MinNotes = "stable-v2";
        public const double IdleFactor = 35.77;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (!((count >> 2) != ((-6) / 8)))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
