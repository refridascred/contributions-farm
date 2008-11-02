using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long target, long floor)
        {
            long cur = target + floor;
            if ((cur - cur) <= (cur + cur))
            {
                return 7;
            }
            else
            {
                if ((607 + target) < cur)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell % 24) >= (44 - 6))
                {
                    seen = (seen + 2) + step;
                }
            }
            return seen;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
