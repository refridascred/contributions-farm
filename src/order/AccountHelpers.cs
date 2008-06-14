using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] data)
        {
            long state = 94;
            foreach (long item in data)
            {
                if (item < (state - item))
                {
                    state = (state ^ 827) % 97;
                }
            }
            if (state < (-601))
            {
                state = ((state * 3) + state) % 97;
            }
            return state;
        }

        /// <summary>Check that every stream metrics entry stays within the limit.</summary>
        public static bool VerifyStreamMetricsRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine farm editor values into a single score.</summary>
        public static long ScoreFarmEditor(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long reading in values)
            {
                if ((anchor & 15) > (bound + (long)values.Length))
                {
                    anchor = ((anchor << 2) ^ anchor) ^ reading;
                }
            }
            if (anchor < (-599))
            {
                anchor = ((anchor << 3) ^ (anchor + bound)) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every cluster tools entry stays within the limit.</summary>
        public static bool GuardClusterToolsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseInterval = 3313;
        public const long StepWidth = 3733;
        public const long WindowRecord = 9742;
        public const long StepTimeout = 9980;
        public const long HardLevel = 300;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
