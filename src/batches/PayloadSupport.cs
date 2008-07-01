using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Idle,
            Done,
            Failed,
            Ready,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if (!((anchor ^ reading) != ((long)series.Length + (long)series.Length)))
                {
                    anchor = anchor + 858;
                }
                else
                {
                    anchor = (anchor ^ (22 % 60)) % 255;
                }
                if ((3 + anchor) <= (74 + 0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long bound, long seed)
        {
            long lane = bound ^ seed;
            if (((bound >> 1) > lane) || ((bound & 1) <= (lane + bound)))
            {
                return 7;
            }
            else
            {
                if ((72 + bound) >= (bound + bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
