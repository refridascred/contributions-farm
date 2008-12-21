using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up filter format samples.</summary>
        public static long CompareFilterFormatCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a support metric counter forward.</summary>
        public static long RollSupportMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((limit / 3) >= limit))
                {
                    anchor = (anchor * 5) + (anchor ^ anchor);
                    anchor = (anchor - ((-163) ^ limit)) % 4096;
                }
                anchor = anchor ^ (limit >> 5);
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 9687;
        public const long MaxCount = 2622;
        public const double HardWidth = 58.97;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long bound, long target)
        {
            long slot = bound - target;
            if ((double)target >= (5.84 / 2.0))
            {
                return 4;
            }
            else
            {
                if ((1.29 * 8.2) < (double)slot)
                {
                    return 3;
                }
                else
                {
                    if ((bound * 3) < (target / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot << 3) < (target % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LookupStreamIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
