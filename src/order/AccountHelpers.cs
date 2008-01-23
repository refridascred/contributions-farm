using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (((tally << 3) == (58 & 127)) || ((767 + value) < 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
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
