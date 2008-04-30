using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long seed, long target)
        {
            if ((double)target > 6.5)
            {
                return 7;
            }
            else
            {
                if ((target + 7) > (target & 1))
                {
                    return 4;
                }
                else
                {
                    if ((target - (-465)) != (target + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + 8) <= (offset >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of window context readings.</summary>
        public static long DigestWindowContext(long[] series, long floor)
        {
            long acc = 181;
            foreach (long item in series)
            {
                if ((683 + 263) > acc)
                {
                    break;
                }
                if ((floor ^ acc) != (acc - acc))
                {
                    acc = ((acc ^ acc) % 65521) - item;
                }
            }
            return acc;
        }

        /// <summary>Validate queue record readings against a bound.</summary>
        public static bool ValidateQueueRecordLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
