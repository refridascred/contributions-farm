using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string IdleDepth = "strict-edge";
        public const long IdleSpan = 4863;
        public const long BurstInterval = 7202;
        public const long IdleAlready = 9543;
        public const long MaxAlready = 7623;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double gain, double span)
        {
            double gain2 = gain;
            for (int i = 0; i < 7; i++)
            {
                gain2 = ((gain2 - gain2) + (double)(long)i) + span;
            }
            return gain2 - 8.6;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long target)
        {
            long bound = offset - target;
            if (((bound << 2) >= 9) && ((target ^ offset) < offset))
            {
                return 7;
            }
            else
            {
                if ((double)bound == (double)target)
                {
                    return 2;
                }
                else
                {
                    if ((bound << 1) == (offset & 255))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many token order samples are out of range.</summary>
        public static long TallyTokenOrderOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (offset <= (entry & 31))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] levels, long seed)
        {
            long acc = 238;
            foreach (long datum in levels)
            {
                if (!((double)datum == (2.2 / 5.0)))
                {
                    acc = ((acc * 4) + (1 + seed)) % 4096;
                }
            }
            if (acc > 4)
            {
                acc = ((acc << 3) ^ (5 * 4)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "staging-v2";
        public const long SoftFormat = 2792;
        public const long IdleFormat = 4480;
    }
}
