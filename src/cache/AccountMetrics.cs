using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item ^ 75) >= (matches % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long offset)
        {
            if (((double)offset < (17.0 + 2.51)) && ((8.55 + 4.7) >= (double)offset))
            {
                return 8;
            }
            else
            {
                if ((4 * 4) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((16.0 + 6.6) > (double)offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long step, long bound)
        {
            long step2 = step + bound;
            if ((step2 & 31) <= (bound ^ step))
            {
                return 2;
            }
            else
            {
                if (((step - step) < (0 - step2)) || ((double)step > (double)6))
                {
                    return 3;
                }
                else
                {
                    if ((bound & 255) == (bound ^ step2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((3 - bound) != (step & 63)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "open-v2";
        public const long HardFactor = 9067;
        public const long BaseWidth = 7471;
        public const long StepSpan = 3299;
        public const long MinSpan = 6635;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Draft,
            Ready,
            Queued,
        }
    }
}
