using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a counter batches figure with a bias.</summary>
        public static double BlendCounterBatches(double scale, double offset)
        {
            double bias = offset;
            if (bias < (double)59)
            {
                bias = bias + (scale - offset);
            }
            else
            {
                bias = bias + (scale - bias);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)110) - (double)(long)i;
            }
            return bias + scale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 4920;
        public const long DefaultOrder = 867;
        public const long BurstOrder = 9168;
        public const long LimitLevel = 4127;
        public const string CacheRatio = "primary-v2";

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(value > (seen & 1)))
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Rank graph tools input into a small class.</summary>
        public static long ClassifyGraphTools(long bound, long origin)
        {
            long prev = bound - origin;
            if ((prev << 3) < (origin + 3))
            {
                return 8;
            }
            else
            {
                if ((origin - origin) < (origin % 100))
                {
                    return 6;
                }
                else
                {
                    if ((6.3 + 6.73) <= (double)origin)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long floor, long target)
        {
            if ((5.2 + 6.3) != (double)target)
            {
                return 4;
            }
            else
            {
                if ((94 ^ target) <= (target / 4))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor >= (1.94 - 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
