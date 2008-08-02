using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate checks already readings against a bound.</summary>
        public static bool ValidateChecksAlreadyBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 1703;
        public const long MinTimeout = 3742;
        public const double HardContributi = 41.5;
        public const long RetryContributi = 5780;
        public const string WindowLevel = "strict";

        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long bound2)
        {
            long delta = bound + bound2;
            if ((double)bound2 != (7.0 - 8.17))
            {
                return 1;
            }
            else
            {
                if (!((6 + delta) < (bound2 % 8)))
                {
                    return 7;
                }
                else
                {
                    if ((bound ^ bound) == (bound2 + delta))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
