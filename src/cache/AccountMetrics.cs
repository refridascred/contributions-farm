using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Classify a queue route pair into a bucket.</summary>
        public static long SortQueueRoute(long limit, long floor)
        {
            long diff = limit - floor;
            if ((floor >= (floor << 2)) && ((12 - limit) >= ((-9) - diff)))
            {
                return 6;
            }
            else
            {
                if ((diff < (diff % 100)) || ((939 * 4) < (limit + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((diff + diff) > limit)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - limit) < (323 / 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a format command pair into a bucket.</summary>
        public static long SortFormatCommand(long step, long bound)
        {
            if ((double)(-59) >= (double)bound)
            {
                return 4;
            }
            else
            {
                if (!((step + (-904)) <= (step * 3)))
                {
                    return 3;
                }
                else
                {
                    if (step > (step << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4 & 7) <= (bound >> 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "open-v2";
        public const long HardFactor = 9067;
        public const long BaseWidth = 7471;
        public const long StepSpan = 3299;
        public const long MinSpan = 6635;

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Pending,
            Failed,
            Synced,
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
