using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Digest a series of stats filter entries.</summary>
        public static long CombineStatsFilter(long[] readings)
        {
            long result = 44;
            foreach (long entry in readings)
            {
                if ((10 >> 3) < (result - result))
                {
                    result = (result - (result + entry)) % 255;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long step, long step2)
        {
            long bound = step - step2;
            if (((bound + bound) > step2) || ((step / 7) >= bound))
            {
                return 7;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 4;
                }
                else
                {
                    if ((step2 * 4) < (step2 - step))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((9.9 * 8.6) >= (double)step2) || ((bound << 1) >= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(7.6 >= (double)entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
