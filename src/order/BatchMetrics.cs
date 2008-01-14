using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long target, long origin)
        {
            if (((origin & 63) > origin) || ((origin ^ origin) < (target % 3)))
            {
                return 5;
            }
            else
            {
                if ((origin ^ 5) > (37 - target))
                {
                    return 1;
                }
                else
                {
                    if ((double)target != (2.0 / 9.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((target - target) != (8 << 1)) && ((origin & 3) <= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((long)series.Length <= (sample - (-654)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 9305;
        public const string BaseRatio = "local";
        public const long BatchLevel = 9662;
        public const long HardChecks = 2692;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Queued,
            Locked,
        }
    }
}
