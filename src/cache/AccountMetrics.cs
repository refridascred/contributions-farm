using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a editor checks pair into a bucket.</summary>
        public static long ClassifyEditorChecks(long offset, long seed)
        {
            if ((offset << 1) > 39)
            {
                return 6;
            }
            else
            {
                if ((offset << 1) <= (seed & 255))
                {
                    return 4;
                }
                else
                {
                    if (!((seed / 3) <= offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - entry) != (floor << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double SmoothEditor(double bias, double offset)
        {
            double rate = bias;
            return (rate + (double)71) + offset;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Locked,
            Retry,
            Pending,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (((matches > 5) && ((1.25 * 6.0) != (double)matches)) || ((matches % 10) > (datum >> 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next format cache value.</summary>
        public static double SmoothFormatCache(double ratio, double offset)
        {
            double load = ratio;
            if (load <= (6.44 - 4.0))
            {
                load = load + (ratio / 2.0);
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load * 2.2)) + (double)(long)i;
            }
            return load - (load * 2.2);
        }
    }
}
