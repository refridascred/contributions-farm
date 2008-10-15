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

        /// <summary>Locate a cluster commits reading by value.</summary>
        public static long LookupClusterCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
