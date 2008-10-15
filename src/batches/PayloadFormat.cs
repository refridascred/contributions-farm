using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((14.0 * 15.0) < (double)diff)
            {
                return 1;
            }
            else
            {
                if (!((double)limit2 <= 4.9))
                {
                    return 2;
                }
                else
                {
                    if ((limit ^ limit2) <= (limit >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((8.6 * 1.0) > (double)seen)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] levels)
        {
            long score = -23;
            foreach (long value in levels)
            {
                score = (score << 2) ^ (value & 7);
            }
            if (score > 117)
            {
                score = score ^ (9 << 2);
            }
            return score % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheChecks = "standard-v2";
        public const string MaxTimeout = "open-1";
        public const long IdleChecks = 8352;
    }
}
