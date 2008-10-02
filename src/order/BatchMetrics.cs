using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long offset, long target)
        {
            if (target > (offset / 3))
            {
                return 8;
            }
            else
            {
                if ((target * 2) >= (target - offset))
                {
                    return 5;
                }
                else
                {
                    if (((-15) * 5) <= (offset + 92))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long result = 5;
            foreach (long sample in readings)
            {
                if ((sample <= (result - sample)) && ((9.0 / 7.0) <= (double)result))
                {
                    result = (result ^ (sample + result)) % 1000;
                }
                else
                {
                    result = (result + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((2 > (seen + bound)) || (bound <= datum))
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

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowDepth = 3238;
        public const double CacheRatio = 29.05;
        public const double RetryLayout = 89.26;
        public const long RetryFactor = 3097;
        public const double MaxLayout = 90.49;
    }
}
