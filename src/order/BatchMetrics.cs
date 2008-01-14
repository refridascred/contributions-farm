using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long floor)
        {
            long step = seed - floor;
            if ((floor - step) <= (floor % 10))
            {
                return 3;
            }
            else
            {
                if (3 >= (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if (8.09 <= (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + floor) == (floor + 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
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
