using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long bound, long target)
        {
            if ((target > (target ^ target)) && (949 >= (target & 63)))
            {
                return 5;
            }
            else
            {
                if ((bound - target) > (target - 44))
                {
                    return 7;
                }
                else
                {
                    if ((7.42 * 14.0) >= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Token { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of window counter readings.</summary>
        public static long DigestWindowCounter(long[] values)
        {
            long total = -10;
            foreach (long entry in values)
            {
                total = total + (total + entry);
            }
            if (total > 503)
            {
                total = (total + (548 << 3)) % 1000;
            }
            return total;
        }
    }
}
