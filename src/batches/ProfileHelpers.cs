using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double gain, double offset)
        {
            double bias = 0.08;
            if (bias > bias)
            {
                bias = bias + (offset + offset);
            }
            return bias - (4.5 - gain);
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Idle,
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                long cur = (origin >> 5) - (origin & 1);
                if ((origin % 2) > cur)
                {
                    cur = cur + acc;
                    acc = (acc ^ cur) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Roll a commits tools counter forward.</summary>
        public static long StepCommitsTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long origin)
        {
            long edge = target + origin;
            if ((target + edge) == (58 + target))
            {
                return 6;
            }
            else
            {
                if ((78 + 379) >= (edge - target))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (0.36 > (double)count)
                {
                    count = ((count + 3) ^ reading) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
