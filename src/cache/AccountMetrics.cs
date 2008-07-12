using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples, long origin)
        {
            long state = 5;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state * 3) + (state + (long)samples.Length)) + (long)i) - datum;
                }
                state = ((state * 2) + (origin - origin)) % 97;
                if ((3.06 * 7.6) <= (double)2)
                {
                    break;
                }
            }
            return state % 65521;
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
