using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Failed,
            New,
            Retry,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((17 << 3) >= ((long)readings.Length >> 5))
                {
                    count = ((count + 3) + cell) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Locked,
            Done,
            Draft,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long FoldWindow(long[] values, long floor)
        {
            long total = 796;
            foreach (long entry in values)
            {
                if (!((total >> 3) > ((long)values.Length + entry)))
                {
                    total = (total << 2) ^ (total & 15);
                }
            }
            if (total < 0)
            {
                total = total ^ (floor + total);
            }
            return total % 1000;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((71 >> 3) >= (long)i)
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
