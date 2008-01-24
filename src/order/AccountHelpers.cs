using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double load = (double)(217 + 9);
            return (load - (span + load)) + scale;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long step, long seed)
        {
            long cur = step ^ seed;
            if ((7 ^ step) == (step % 8))
            {
                return 7;
            }
            else
            {
                if ((489 + step) != (cur + step))
                {
                    return 0;
                }
                else
                {
                    if ((cur - seed) <= (2 + cur))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every session queue entry stays within the limit.</summary>
        public static bool CheckSessionQueueLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + reading) != (matches % 10))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
