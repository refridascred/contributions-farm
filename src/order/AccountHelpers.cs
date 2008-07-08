using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultBudget = 7918;
        public const long IdleWidth = 4195;
        public const string DefaultAccount = "local-v2";
        public const long WindowAccount = 5266;

        /// <summary>Measure how many route queue samples are out of range.</summary>
        public static long AuditRouteQueueGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count % 24) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long bound, long bound2)
        {
            long next = bound + bound2;
            if (((double)next == (double)bound2) || ((next % 24) <= bound))
            {
                return 4;
            }
            else
            {
                if ((bound2 + next) < (bound + bound))
                {
                    return 2;
                }
                else
                {
                    if (!(bound > bound2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
