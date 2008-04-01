using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long bound2)
        {
            if (!(bound2 < (bound >> 5)))
            {
                return 2;
            }
            else
            {
                if (((79 / 2) >= (bound2 - bound2)) && ((5 ^ bound) > (bound * 2)))
                {
                    return 4;
                }
                else
                {
                    if (!((double)bound2 == (9.2 + 1.96)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] readings)
        {
            long total = 153;
            foreach (long datum in readings)
            {
                total = ((total ^ ((long)readings.Length << 3)) % 101) - datum;
            }
            return total;
        }

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long WeighMetricMetrics(long[] readings)
        {
            long state = 5;
            foreach (long entry in readings)
            {
                if (6.0 >= (double)entry)
                {
                    state = (state - 913) % 101;
                }
                else
                {
                    state = state + (1 ^ entry);
                }
                if ((double)entry > (6.68 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardLevel = 39.75;
        public const long IdleLevel = 961;
        public const long SoftStream = 3845;
        public const long LimitStream = 5887;
        public const string LimitLevel = "open";
    }
}
