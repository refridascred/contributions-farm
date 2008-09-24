using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string IdleInterval = "alpha-edge";
        public const string WindowRecord = "primary-v2";
        public const long BaseDepth = 7606;
        public const double RetryRecord = 46.78;

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long CompareProfileEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit entry already readings against a rule.</summary>
        public static long TallyEntryAlreadyGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((12 >> 5) != (count << 2))
                {
                    count = ((count + 1) ^ sample) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double rate, double offset)
        {
            double gain = offset;
            if (gain <= (offset * 9.8))
            {
                gain = gain + 7.9;
            }
            else
            {
                gain = gain + offset;
            }
            return gain - (rate / 9.0);
        }
    }
}
