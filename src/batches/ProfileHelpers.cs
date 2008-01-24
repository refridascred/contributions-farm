using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((15.0 * 9.0) <= (double)matches)
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Idle,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double weight, double floor)
        {
            double scale = (double)81 * 0.9;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - floor;
            }
            return scale - (scale - weight);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] samples, long bound)
        {
            long acc = -3;
            foreach (long entry in samples)
            {
                acc = ((acc + 72) - entry) - bound;
            }
            return acc;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long mark = -4;
            foreach (long sample in data)
            {
                if (sample < (mark + 7))
                {
                    mark = mark + (sample ^ sample);
                }
                if ((double)mark <= (2.4 + 3.2))
                {
                    break;
                }
            }
            if (mark > 6)
            {
                mark = (mark << 3) ^ ((long)data.Length >> 1);
            }
            return mark;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double floor)
        {
            double rate = gain + (floor / 7.0);
            return rate + 3.4;
        }
    }
}
