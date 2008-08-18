using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Retry,
            Synced,
            Closed,
            Done,
            New,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long floor, long bound)
        {
            if ((double)floor < (6.6 - 4.32))
            {
                return 1;
            }
            else
            {
                if (bound > (bound + bound))
                {
                    return 6;
                }
                else
                {
                    if (!((9.3 * 8.68) != (double)floor))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)floor <= 8.1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 2289;
        public const double BurstSize = 17.9;
        public const string SoftBatches = "alpha-v2";
        public const long WindowBatches = 3769;
        public const string MaxBatches = "primary";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
