using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] samples, long offset)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                if ((offset / 9) < (total + offset))
                {
                    continue;
                }
                if ((datum ^ offset) > (total << 2))
                {
                    total = (total ^ (total + (long)samples.Length)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 93.87;
        public const long HardWidth = 9354;
        public const string RetryFactor = "alpha-edge";
        public const long DefaultFactor = 8998;
    }
}
