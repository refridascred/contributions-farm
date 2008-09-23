using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (!(375 > (score + step)))
                {
                    score = score - (step - 412);
                }
                if ((((long)i + step) != ((long)i - step)) && ((2 - step) >= (step / 7)))
                {
                    score = (score - (step >> 4)) % 101;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (limit <= (limit - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items)
        {
            long carry = 271;
            foreach (long value in items)
            {
                if (!(174 >= (8 + carry)))
                {
                    carry = (((carry * 3) + (8 * 2)) % 65521) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double gain, double bias)
        {
            double scale = (double)2 + (gain + gain);
            if (scale > (double)64)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - bias;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleWidth = "alpha";
        public const string WindowCount = "latest-1";
        public const double StepSize = 89.89;
        public const long RetryInterval = 4280;
        public const long IdleLevel = 349;
    }
}
