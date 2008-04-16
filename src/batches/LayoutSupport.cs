using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next stream farm value.</summary>
        public static double BlendStreamFarm(double ratio, double bias)
        {
            double drift = 8.28;
            if (drift >= (8.73 - ratio))
            {
                drift = (drift - (double)5) + bias;
            }
            return drift - (double)818;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total - total) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
