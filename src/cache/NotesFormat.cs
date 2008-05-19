using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long total = 202;
            foreach (long item in series)
            {
                total = ((total << 3) ^ total) + item;
                if (!((total & 31) > (total / 9)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 63;
        public const long MaxContext = 569;
        public const long CacheSpan = 4873;
        public const string BurstCount = "primary-edge";

        /// <summary>Rank batch context input into a small class.</summary>
        public static long BucketBatchContext(long step, long step2)
        {
            long step3 = step + step2;
            if ((step2 <= (step2 / 5)) || (step2 <= (step - step)))
            {
                return 5;
            }
            else
            {
                if (step > (step2 * 4))
                {
                    return 6;
                }
                else
                {
                    if (((step3 & 7) < (step + step)) && (step2 <= 9))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step2 > (9.95 * 2.9)) && ((step & 31) < (step2 * 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
