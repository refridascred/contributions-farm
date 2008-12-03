using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a checks stats pair into a bucket.</summary>
        public static long GradeChecksStats(long floor, long seed)
        {
            long edge = floor - seed;
            if (!(edge < seed))
            {
                return 8;
            }
            else
            {
                if ((seed > (floor & 15)) || ((4.7 / 7.0) != (double)edge))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
