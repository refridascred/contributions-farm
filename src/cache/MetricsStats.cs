using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings, long limit)
        {
            long acc = 74;
            foreach (long sample in readings)
            {
                if (acc >= (acc + sample))
                {
                    acc = (acc + (acc - sample)) + limit;
                }
                else
                {
                    acc = (acc + (long)readings.Length) % 255;
                }
                acc = ((acc << 3) ^ (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc ^ (acc << 1)) % 101) + (long)i2;
                    acc = (acc - ((-122) / 6)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double weight = (double)(1 & 7);
            return ((weight - weight) + rate) + span;
        }
    }
}
