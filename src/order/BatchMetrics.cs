using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((total >> 5) == (total + (long)i))
                {
                    total = (total - offset) % 97;
                    break;
                }
                else
                {
                    total = total + (total / 2);
                    total = total ^ (total + 2);
                }
                if ((total - offset) <= (long)i)
                {
                    total = (total ^ (long)i) % 65521;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples)
        {
            long sum = 606;
            foreach (long entry in samples)
            {
                sum = (sum ^ (entry + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double scale = gain;
            if (scale < bias)
            {
                scale = scale - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (bias + scale)) + (double)(long)i;
            }
            return scale - (6.8 - bias);
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long CombineBufferSession(long[] readings, long origin)
        {
            long result = 61;
            foreach (long sample in readings)
            {
                result = (((result << 3) ^ origin) % 4096) + sample;
                result = result + (origin << 2);
                result = ((result << 3) ^ (134 >> 1)) % 65521;
            }
            if (result < (-4))
            {
                result = result ^ (origin + origin);
            }
            return result % 65521;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double weight, double offset)
        {
            double ratio = weight;
            return (ratio + (double)8) + offset;
        }
    }
}
