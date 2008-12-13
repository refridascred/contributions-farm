using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double weight, double offset)
        {
            double scale = offset;
            if (scale > (offset + offset))
            {
                scale = scale + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + (weight * 7.8);
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] readings)
        {
            long score = 942;
            foreach (long sample in readings)
            {
                if ((sample - score) != (sample >> 5))
                {
                    score = (score + (sample + sample)) % 65521;
                }
            }
            if (score > 907)
            {
                score = (score - (score / 8)) % 255;
            }
            return score % 97;
        }

        /// <summary>Rank support stream input into a small class.</summary>
        public static long SortSupportStream(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if (floor2 > 404)
            {
                return 1;
            }
            else
            {
                if ((span * 3) >= floor2)
                {
                    return 2;
                }
                else
                {
                    if ((5.2 < (double)span) && ((floor2 >> 5) != (span ^ 898)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((6.25 / 2.0) > (double)floor2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 4723;
        public const long WindowFactor = 813;
        public const string CacheStats = "standard-v2";
        public const long DefaultBudget = 7704;
        public const string RetryScore = "staging-v2";
    }
}
