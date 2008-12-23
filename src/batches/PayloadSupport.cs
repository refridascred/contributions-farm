using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long step, long bound)
        {
            if (((4 / 8) <= bound) && ((double)step <= (7.5 - 7.0)))
            {
                return 7;
            }
            else
            {
                if ((bound << 3) == (step + bound))
                {
                    return 8;
                }
                else
                {
                    if ((step % 60) >= (571 - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((327 & 7) >= (bound - bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((46 + tally) < (limit * 2)) || ((limit / 6) > (94 - tally))) || (8.45 < (double)limit))
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }
    }
}
