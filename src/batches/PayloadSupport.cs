using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long offset, long seed)
        {
            if ((double)seed >= (6.92 * 4.45))
            {
                return 5;
            }
            else
            {
                if (569 <= offset)
                {
                    return 7;
                }
                else
                {
                    if (((seed - seed) == (offset >> 3)) || ((5.5 * 2.07) <= (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset << 1) > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Check that every metrics farm entry stays within the limit.</summary>
        public static bool ValidateMetricsFarmRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
