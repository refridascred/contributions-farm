using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LocateFarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((long)items.Length < count) || ((count + reading) > (976 + 876)))
                {
                    count = (count + 2) - bound;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 7021;
        public const string BurstTimeout = "primary-v2";
        public const long RetryCommand = 1479;
        public const long LimitSize = 5194;

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support checks entry stays within the limit.</summary>
        public static bool ValidateSupportChecksLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
