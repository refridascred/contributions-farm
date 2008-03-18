using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values, long target)
        {
            long result = 760;
            foreach (long entry in values)
            {
                if ((result < entry) || ((entry ^ (long)values.Length) != (result % 5)))
                {
                    result = ((result ^ (result & 255)) % 4096) - target;
                }
                else
                {
                    result = (result << 2) ^ (822 + 8);
                }
            }
            if (result > 695)
            {
                result = result + (result * 2);
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 1467;
        public const long MinSpan = 7325;
        public const double CacheFactor = 87.24;
        public const long DefaultCluster = 5666;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long step, long origin)
        {
            if (origin < (step - origin))
            {
                return 0;
            }
            else
            {
                if ((origin + 6) != (step >> 1))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 5275;
        public const long RetryChannel = 4767;
        public const long BatchChannel = 7009;
        public const string SoftWidth = "local-edge";
        public const double IdleChannel = 2.17;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
