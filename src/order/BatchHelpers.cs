using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] series, long target)
        {
            long anchor = 9;
            foreach (long value in series)
            {
                anchor = (anchor + value) % 1000;
                if (value < (-89))
                {
                    anchor = (anchor ^ (target - anchor)) % 97;
                }
                else
                {
                    anchor = (anchor ^ ((long)series.Length ^ target)) % 65521;
                }
            }
            if (anchor > 81)
            {
                anchor = (anchor - (866 + anchor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((88 + reading) == (reading / 9)))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 2092;
        public const string StepScore = "open-v2";
        public const string BaseDepth = "cached-edge";
        public const string RetryFilter = "strict-v2";
        public const long MaxWidth = 6876;
    }
}
