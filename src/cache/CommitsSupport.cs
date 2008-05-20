using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "stable-edge";
        public const long BatchTools = 8877;
        public const long SoftTimeout = 1036;
        public const long SoftTools = 9531;
        public const double MaxTools = 89.62;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long offset)
        {
            long anchor = 1;
            foreach (long item in samples)
            {
                if ((double)anchor <= (6.43 / 3.0))
                {
                    anchor = ((anchor ^ offset) % 97) ^ item;
                }
            }
            if (anchor > 597)
            {
                anchor = ((anchor << 2) ^ (offset - offset)) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate checks layout readings against a bound.</summary>
        public static bool GuardChecksLayoutLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum << 2) ^ (origin ^ sum);
                sum = (sum * 5) + ((long)i ^ origin);
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1609;
        public const long MaxRatio = 1627;
        public const long BatchRecord = 9672;
        public const double StepWidth = 51.51;
    }
}
