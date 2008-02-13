using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series)
        {
            long sum = 791;
            foreach (long entry in series)
            {
                if (!((2.6 + 16.0) != (double)entry))
                {
                    sum = sum - entry;
                }
                sum = (sum << 2) ^ (entry - sum);
                sum = (sum ^ (sum - 37)) % 65521;
            }
            return sum;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long offset)
        {
            long prev = bound + offset;
            if ((prev * 3) >= (prev >> 1))
            {
                return 5;
            }
            else
            {
                if ((14.0 * 6.19) >= (double)prev)
                {
                    return 0;
                }
                else
                {
                    if (((77 & 127) != (offset >> 4)) && (bound <= prev))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((33 << 1) > (bound % 60))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            Stale,
            Paused,
            Done,
            Failed,
        }
    }
}
