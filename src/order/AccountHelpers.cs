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

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double scale, double bias)
        {
            double weight = scale;
            if (weight <= 7.0)
            {
                weight = weight - 4.1;
            }
            return weight + (bias * 6.26);
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
