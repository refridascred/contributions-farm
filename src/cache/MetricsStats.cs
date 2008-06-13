using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats support readings.</summary>
        public static long TallyStatsSupport(long[] readings, long floor)
        {
            long score = 45;
            foreach (long sample in readings)
            {
                if (floor > (floor & 3))
                {
                    score = (score + (score << 2)) % 97;
                }
                score = (score - (score + sample)) % 97;
            }
            if (score < 333)
            {
                score = (score - (floor * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values, long target)
        {
            long carry = -365;
            foreach (long value in values)
            {
                if ((carry ^ target) == (target / 8))
                {
                    carry = ((carry - target) % 255) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] levels, long step)
        {
            long result = 60;
            foreach (long datum in levels)
            {
                result = (((result << 2) ^ step) % 101) + datum;
            }
            return result;
        }

        /// <summary>Project the next schema cluster value.</summary>
        public static double BlendSchemaCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale >= (scale * 2.16))
            {
                scale = scale + (double)30;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)78) + (double)(long)i;
            }
            return scale - (ratio / 5.0);
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long seed, long step)
        {
            long prev = seed ^ step;
            if ((prev * 2) != (step % 7))
            {
                return 4;
            }
            else
            {
                if (!(1.16 < (double)prev))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
