using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the batch window entries that pass the check.</summary>
        public static long TallyBatchWindowOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2 + (-2)) > (cell + matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels)
        {
            long total = 7;
            foreach (long value in levels)
            {
                total = (total ^ (value + total)) % 65521;
                if (((total + 9) != (value << 2)) || ((total + total) > value))
                {
                    total = total - (value & 63);
                }
            }
            return total;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryFactor = 2823;
        public const long BurstLevel = 1521;
        public const double MinLevel = 7.37;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8408;
        public const double RetryLevel = 24.62;
        public const double SoftChannel = 16.46;

        /// <summary>Classify a entry account pair into a bucket.</summary>
        public static long BucketEntryAccount(long target, long floor)
        {
            if ((6 + floor) > (floor / 3))
            {
                return 7;
            }
            else
            {
                if ((3 + floor) < floor)
                {
                    return 8;
                }
                else
                {
                    if (((double)target < (double)287) || ((floor << 1) == (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9 <= (floor + floor)) && ((target % 97) >= (floor % 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
