using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 13;
            foreach (long sample in readings)
            {
                if (!(891 < sample))
                {
                    carry = (carry ^ sample) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum + 36) > (matches + datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long seed, long offset)
        {
            long span = seed ^ offset;
            if ((offset >> 5) <= seed)
            {
                return 6;
            }
            else
            {
                if ((((-754) - span) > offset) || ((offset + 0) <= (8 - offset)))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) > (span << 2))
                    {
                        return 2;
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
