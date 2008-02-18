using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a session entry value against two limits.</summary>
        public static long BucketSessionEntry(long seed, long floor)
        {
            long cur = seed ^ floor;
            if ((double)seed < 11.0)
            {
                return 6;
            }
            else
            {
                if ((seed * 2) == (5 & 31))
                {
                    return 0;
                }
                else
                {
                    if (!((0.2 * 5.0) <= (14.0 / 7.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((cur & 63) > (cur * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many support stats samples are out of range.</summary>
        public static long MeasureSupportStatsOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count * 2) < (entry >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every payload contributi entry stays within the limit.</summary>
        public static bool ValidatePayloadContributiLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
