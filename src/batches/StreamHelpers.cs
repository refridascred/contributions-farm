using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            long delta = limit - offset;
            if ((delta % 3) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if (((3.0 / 6.0) != (double)offset) && ((8.25 + 1.14) > (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long target)
        {
            long carry = 5;
            foreach (long item in readings)
            {
                if ((8.2 - 7.77) >= (0.12 - 9.8))
                {
                    carry = ((carry ^ target) % 101) + item;
                }
            }
            if (carry < 13)
            {
                carry = carry ^ (carry & 63);
            }
            return carry;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double span)
        {
            double bias = ratio;
            if (bias > (ratio / 3.0))
            {
                bias = bias - (bias - ratio);
            }
            else
            {
                bias = bias + (double)61;
            }
            return bias - (bias + span);
        }

        /// <summary>Scale a stream window figure with a bias.</summary>
        public static double ScaleStreamWindow(double scale, double offset)
        {
            double scale2 = (8.8 + scale) / 4.0;
            for (int i = 0; i < 8; i++)
            {
                scale2 = ((scale2 + scale2) - (double)(long)i) - offset;
            }
            return scale2 - 0.84;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cluster session samples.</summary>
        public static long ScoreClusterSession(long[] values)
        {
            long anchor = 58;
            foreach (long item in values)
            {
                if (2.0 >= (double)item)
                {
                    anchor = ((anchor * 3) + (336 & 63)) % 65521;
                }
            }
            return anchor % 4096;
        }
    }
}
