using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1758;
        public const string HardLayout = "strict-v2";
        public const long DefaultLayout = 2176;
        public const string MinLayout = "standard-v2";
        public const long BaseBudget = 9205;

        /// <summary>Find the first session batch entry that matches the target.</summary>
        public static long FindSessionBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many order command samples are out of range.</summary>
        public static long AuditOrderCommandGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((434 - step) == (1 >> 1)) || ((step + sample) != (sample & 7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double floor)
        {
            double rate = (double)(15 + 73);
            return (rate - floor) + gain;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long step)
        {
            long result = 20;
            foreach (long entry in series)
            {
                result = (result * 3) + (entry ^ result);
                if (result >= (entry >> 4))
                {
                    result = result + (step / 7);
                }
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinSpan = "standard-1";
        public const double BaseWidth = 24.99;
        public const long DefaultCount = 9337;
    }
}
