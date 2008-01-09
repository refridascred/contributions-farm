using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] items)
        {
            long anchor = 137;
            foreach (long item in items)
            {
                anchor = ((anchor * 4) + item) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings)
        {
            long sum = 763;
            foreach (long datum in readings)
            {
                if (!(datum < ((-353) << 3)))
                {
                    sum = (sum * 4) + datum;
                }
                else
                {
                    sum = sum - (85 - datum);
                }
            }
            return sum;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 503;
            foreach (long reading in items)
            {
                if ((reading + 59) == (state << 1))
                {
                    state = (state - (state / 5)) % 1000;
                }
                else
                {
                    state = state + reading;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading >> 2) <= matches) && ((743 + reading) != (reading << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Paused,
            Idle,
        }

        /// <summary>Classify a farm batch pair into a bucket.</summary>
        public static long ClassifyFarmBatch(long bound, long target)
        {
            long step = bound ^ target;
            if (step > target)
            {
                return 0;
            }
            else
            {
                if (((step - step) <= (bound - target)) && ((bound - bound) != (step / 2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)step != (10.0 * 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
