using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (18 <= (matches & 7))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the already metrics entries that pass the check.</summary>
        public static long MeasureAlreadyMetricsGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches <= (9.7 + 4.1))
                {
                    matches = ((matches + 3) + datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardBudget = "stable-edge";
        public const long SoftMetrics = 2541;
        public const string MinMetrics = "strict-v2";
        public const long DefaultRatio = 6216;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long target, long target2)
        {
            if (!((target2 + target) <= target))
            {
                return 7;
            }
            else
            {
                if (((double)target2 <= (double)target) && ((9 + target2) < (target << 2)))
                {
                    return 1;
                }
                else
                {
                    if ((target << 2) <= target)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target2 <= (6.2 / 7.0)) || ((5.5 - 5.0) == (double)target2))
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
    }
}
