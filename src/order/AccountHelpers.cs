using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long step)
        {
            long prev = target - step;
            if ((double)step >= (16.0 * 8.6))
            {
                return 6;
            }
            else
            {
                if ((prev + prev) > (8 / 7))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (offset / 9.0))
            {
                mean = mean - (ratio / 6.0);
            }
            else
            {
                mean = mean - (ratio * 6.4);
            }
            return mean - 7.65;
        }

        /// <summary>Audit payload command readings against a rule.</summary>
        public static long AuditPayloadCommandMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)offset != (14.0 / 8.0))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long limit, long target)
        {
            long edge = limit + target;
            if ((limit > (target + limit)) || ((edge + target) != (limit * 2)))
            {
                return 1;
            }
            else
            {
                if ((limit ^ edge) <= (limit + 30))
                {
                    return 5;
                }
                else
                {
                    if ((((-1) + limit) > limit) || ((limit << 2) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long target)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
