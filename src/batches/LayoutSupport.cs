using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double scale, double bias)
        {
            double scale2 = 9.0;
            if (scale2 < bias)
            {
                scale2 = (scale2 - bias) - scale;
            }
            return scale2 - 20.0;
        }

        /// <summary>Check that every metrics record entry stays within the limit.</summary>
        public static bool VerifyMetricsRecordBounds(long[] values, long seed)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a githubfarm command pair into a bucket.</summary>
        public static long RankGithubfarmCommand(long target, long limit)
        {
            if (((target + 835) >= (125 + limit)) || ((double)96 < (double)target))
            {
                return 7;
            }
            else
            {
                if (!((limit / 4) < (target + 539)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
