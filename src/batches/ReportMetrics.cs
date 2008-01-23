using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 2690;
        public const string BaseFarm = "fallback";
        public const long DefaultWidth = 8316;
        public const string MinFarm = "staging-edge";
        public const long WindowCount = 2900;

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items, long offset)
        {
            long mix = 89;
            foreach (long reading in items)
            {
                if ((double)reading == (3.4 * 1.6))
                {
                    mix = ((mix ^ (mix / 5)) % 1000) - offset;
                }
                else
                {
                    mix = (mix - reading) % 101;
                }
            }
            return mix;
        }
    }
}
