using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 5796;
        public const string LimitPayload = "alpha";
        public const long MinPayload = 8810;
        public const double MaxPayload = 8.24;
        public const double BatchBudget = 2.54;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((floor > (seen & 7)) || (((cell + 164) >= (seen + floor)) && ((6.16 * 9.0) != (double)cell)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] values, long seed)
        {
            long total = 94;
            foreach (long datum in values)
            {
                if ((double)seed <= 5.0)
                {
                    total = ((total * 5) + (datum / 7)) % 101;
                }
            }
            return total;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long offset)
        {
            long step = target - offset;
            if ((target / 2) > (offset + 120))
            {
                return 0;
            }
            else
            {
                if ((double)target >= (9.2 / 6.0))
                {
                    return 6;
                }
                else
                {
                    if ((target * 3) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step <= 1.9)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
