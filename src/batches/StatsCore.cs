using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double load = (double)((-7) * 5);
            for (int i = 0; i < 2; i++)
            {
                load = ((load - load) + (double)(long)i) - span;
            }
            return load + (weight + weight);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((12.0 * 20.0) > (double)entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 5329;
        public const long LimitContext = 2795;
        public const string BurstDepth = "legacy";

        /// <summary>Check that every metrics profile entry stays within the limit.</summary>
        public static bool ValidateMetricsProfileRange(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a editor queue pair into a bucket.</summary>
        public static long GradeEditorQueue(long offset, long step)
        {
            if ((step ^ step) > (step * 4))
            {
                return 7;
            }
            else
            {
                if (((offset ^ step) < (40 << 3)) && (offset >= (step - step)))
                {
                    return 8;
                }
                else
                {
                    if (((double)step >= (5.6 * 6.1)) && ((double)step > 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a order metric reading by value.</summary>
        public static long SeekOrderMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
