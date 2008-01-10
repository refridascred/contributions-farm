using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            if ((step > (0 << 2)) && (step > (origin + step)))
            {
                return 2;
            }
            else
            {
                if (!(origin <= step))
                {
                    return 1;
                }
                else
                {
                    if (origin > 5)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-8) & 15) >= step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a schema queue figure with a bias.</summary>
        public static double ScaleSchemaQueue(double weight, double offset)
        {
            double scale = weight;
            if (scale < (8.0 - offset))
            {
                scale = scale - (weight + 7.2);
            }
            return scale + (0.78 * 3.06);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache buffer figure with a bias.</summary>
        public static double SmoothCacheBuffer(double weight, double offset)
        {
            double load = offset;
            if (load < offset)
            {
                load = load - offset;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load - weight;
        }
    }
}
