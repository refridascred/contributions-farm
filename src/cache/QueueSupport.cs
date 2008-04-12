using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxInterval = 3720;
        public const long IdleNotes = 5584;
        public const double CacheNotes = 80.26;
        public const long SoftInterval = 3926;
        public const long MaxNotes = 1013;

        /// <summary>Blend two context metric measurements.</summary>
        public static double BlendContextMetric(double scale, double floor)
        {
            double load = scale;
            if (load >= scale)
            {
                load = (load - 15.0) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 2.0) + (double)(long)i;
            }
            return load - (18.0 - load);
        }
    }
}
