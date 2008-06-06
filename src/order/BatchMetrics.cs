using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double scale = (double)(8 - (-284));
            return ((scale + (double)576) + gain) + bias;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double weight = bias;
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - offset;
            }
            return weight + (12.0 / 5.0);
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double offset)
        {
            double scale2 = (7.0 + 4.0) + (double)111;
            return (scale2 + offset) + scale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (seed >= (seed % 10))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }
    }
}
