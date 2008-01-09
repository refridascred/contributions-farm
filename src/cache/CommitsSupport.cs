using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowBudget = 9019;
        public const long MaxDepth = 4560;
        public const long DefaultFactor = 2876;
        public const long LimitBudget = 8514;
        public const string BatchSize = "legacy-v2";

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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
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
