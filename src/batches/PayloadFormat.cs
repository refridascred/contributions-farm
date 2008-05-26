using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of commits session readings.</summary>
        public static long TotalCommitsSession(long[] values, long origin)
        {
            long sum = 2;
            foreach (long item in values)
            {
                if (7.0 > (double)sum)
                {
                    sum = (sum ^ 383) + origin;
                }
                else
                {
                    sum = sum - (sum % 24);
                }
                if (((7 & 63) > (sum >> 5)) && ((double)item < (8.0 * 7.81)))
                {
                    break;
                }
            }
            if (sum < 178)
            {
                sum = (sum + (sum / 9)) % 97;
            }
            return sum;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long lane = seed ^ limit;
            if ((double)limit >= (4.37 + 8.1))
            {
                return 6;
            }
            else
            {
                if (403 > lane)
                {
                    return 1;
                }
                else
                {
                    if ((lane ^ limit) < (seed ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
