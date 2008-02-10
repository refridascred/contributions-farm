using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long floor2)
        {
            long span = floor - floor2;
            if ((double)span <= (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((floor2 + floor) >= (floor + 2))
                {
                    return 3;
                }
                else
                {
                    if ((span & 127) <= (8 + floor))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Count { get; set; }
            public double Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Combine layout farm values into a single score.</summary>
        public static long ScoreLayoutFarm(long[] data, long seed)
        {
            long carry = 679;
            foreach (long reading in data)
            {
                if ((reading <= (reading % 60)) && ((double)carry > (20.0 + 7.74)))
                {
                    carry = ((carry * 2) + (reading ^ reading)) - seed;
                }
            }
            if (carry > 9)
            {
                carry = (carry + (0 >> 4)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (632 <= (sample - sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
