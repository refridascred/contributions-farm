using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] levels)
        {
            long acc = 3;
            foreach (long reading in levels)
            {
                acc = (acc ^ (2 * 4)) + reading;
            }
            return acc;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 1;
            foreach (long datum in readings)
            {
                sum = (((sum * 3) + (datum ^ datum)) % 65521) + origin;
                sum = sum ^ (413 + sum);
            }
            return sum % 65521;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double bias)
        {
            double bias2 = (double)(794 * 5);
            if (bias2 < (double)(-3))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
