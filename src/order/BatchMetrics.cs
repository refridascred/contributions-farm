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

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)0 != (double)cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Ready,
            New,
            Paused,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] values, long seed)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (8 <= (seed ^ count))
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit filter contributi readings against a rule.</summary>
        public static long MeasureFilterContributiOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((((limit ^ limit) <= (-6)) && ((limit % 7) == (item >> 5))) && ((limit + limit) >= (item ^ 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long carry = 90;
            foreach (long datum in samples)
            {
                carry = (carry ^ (carry + datum)) % 65521;
            }
            if (carry < 784)
            {
                carry = ((carry * 3) + (carry ^ carry)) % 255;
            }
            return carry;
        }
    }
}
