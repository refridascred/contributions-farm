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

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long offset, long floor)
        {
            if ((offset * 5) != (offset - offset))
            {
                return 8;
            }
            else
            {
                if (((double)floor != (double)offset) && (10.0 < (2.0 + 9.19)))
                {
                    return 3;
                }
                else
                {
                    if ((9 < (offset % 5)) || ((double)offset != (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((((-127) & 127) > floor) || ((offset ^ offset) != (floor + 39)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
