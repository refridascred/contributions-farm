using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many commits format samples are out of range.</summary>
        public static long CountCommitsFormatHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count & 1) <= item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long origin, long bound)
        {
            if (!((origin + origin) <= (origin - bound)))
            {
                return 4;
            }
            else
            {
                if (!((origin - 8) >= (origin - (-823))))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin <= (double)88)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < (15.0 / 4.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
