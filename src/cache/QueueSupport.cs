using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first cache contributi entry that matches the target.</summary>
        public static long FindCacheContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Scale a metrics farm figure with a bias.</summary>
        public static double BlendMetricsFarm(double bias, double span)
        {
            double scale = bias;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale - (double)104) + (double)(long)i) + span;
            }
            return scale + 3.78;
        }
    }
}
