using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a contributi token value against two limits.</summary>
        public static long GradeContributiToken(long origin, long target)
        {
            if (!(target < origin))
            {
                return 8;
            }
            else
            {
                if (!(origin > target))
                {
                    return 2;
                }
                else
                {
                    if ((origin + origin) != (target >> 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.7 + 3.0) > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBatches = "primary-v2";
        public const long StepScore = 7950;
        public const long BaseFactor = 3555;
        public const long BurstBatches = 7116;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
