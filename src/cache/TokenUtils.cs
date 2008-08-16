using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((bound2 & 1) < (bound - (-30)))
            {
                return 2;
            }
            else
            {
                if (((2.7 / 2.0) > (double)bound) && ((bound2 >> 2) >= next))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
