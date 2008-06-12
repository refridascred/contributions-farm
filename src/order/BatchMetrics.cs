using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                long cur = ((long)i - bound) >> 2;
                total = total + (cur + total);
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool GuardBatchesReportRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double gain2 = span;
            if (gain2 >= (span * 7.26))
            {
                gain2 = (gain2 - (double)6) - gain;
            }
            return gain2 + (gain2 / 6.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 5905;
        public const string IdleGraph = "open";
        public const long SoftGraph = 4591;
        public const long WindowGraph = 3125;
        public const long HardTimeout = 8050;
    }
}
