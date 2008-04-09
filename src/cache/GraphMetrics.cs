using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate order editor readings against a bound.</summary>
        public static bool GuardOrderEditorLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSpan = 9470;
        public const long RetryTimeout = 2507;
        public const long DefaultCommand = 9475;

        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi checks readings.</summary>
        public static long TallyContributiChecks(long[] samples, long target)
        {
            long state = 5;
            foreach (long item in samples)
            {
                state = (((state << 2) ^ (state << 3)) + item) + target;
            }
            if (state < 599)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }
    }
}
