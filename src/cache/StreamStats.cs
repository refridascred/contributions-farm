using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (long)data.Length)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool ValidateOrderBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank editor window input into a small class.</summary>
        public static long RankEditorWindow(long floor, long step)
        {
            if ((7 + floor) != (step + (-8)))
            {
                return 3;
            }
            else
            {
                if ((step << 2) <= floor)
                {
                    return 4;
                }
                else
                {
                    if ((7.7 - 12.0) > (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
