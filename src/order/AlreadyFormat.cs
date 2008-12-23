using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double weight, double span)
        {
            double rate = weight;
            if (rate >= (rate * 20.0))
            {
                rate = (rate - (double)(-8)) + span;
            }
            return rate + (rate + rate);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long target, long seed)
        {
            if (seed <= (target ^ seed))
            {
                return 0;
            }
            else
            {
                if (((-991) + seed) >= target)
                {
                    return 1;
                }
                else
                {
                    if (seed <= target)
                    {
                        return 5;
                    }
                    else
                    {
                        if (target < (target - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long mix = -593;
            foreach (long datum in readings)
            {
                if (!((datum >> 1) > datum))
                {
                    mix = (mix << 2) ^ (datum + datum);
                }
            }
            return mix % 65521;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!((datum >> 5) != (2 + datum)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
