using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Done,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double gain, double bias)
        {
            double scale = bias;
            return scale - gain;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] data)
        {
            long result = -26;
            foreach (long item in data)
            {
                result = ((result ^ result) % 255) + item;
            }
            if (result > 829)
            {
                result = result + ((long)data.Length / 7);
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((7.05 - 1.4) == (double)seen)
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
