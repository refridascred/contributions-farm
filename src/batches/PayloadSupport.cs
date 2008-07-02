using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long seed)
        {
            long lane = bound + seed;
            if ((double)seed < (double)bound)
            {
                return 4;
            }
            else
            {
                if (!(seed >= ((-378) + bound)))
                {
                    return 8;
                }
                else
                {
                    if (!((double)lane > (7.52 * 2.36)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.1 * 0.8) >= (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate commits token readings against a bound.</summary>
        public static bool VerifyCommitsTokenLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
