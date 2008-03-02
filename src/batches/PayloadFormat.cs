using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseFactor = 9968;
        public const long DefaultBudget = 4300;
        public const long RetryCommits = 7848;
        public const string RetryScore = "cached-v2";

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)tally == (5.0 / 2.0))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                if ((2.3 - 9.0) <= (double)(long)i)
                {
                    result = (result << 2) ^ ((-60) - offset);
                }
                if (result <= offset)
                {
                    result = ((result * 2) + result) % 101;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Rank batches notes input into a small class.</summary>
        public static long GradeBatchesNotes(long seed, long limit)
        {
            long prev = seed + limit;
            if (seed < (prev ^ prev))
            {
                return 3;
            }
            else
            {
                if ((double)limit < 2.58)
                {
                    return 5;
                }
                else
                {
                    if (((prev - seed) >= (169 + limit)) && ((5.0 + 9.51) != (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-1) % 64) < prev)
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
        }
    }
}
