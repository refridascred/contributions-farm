using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long step, long bound)
        {
            if ((bound ^ bound) > bound)
            {
                return 5;
            }
            else
            {
                if (((step + bound) == (step ^ bound)) && ((step + step) <= (bound - bound)))
                {
                    return 3;
                }
                else
                {
                    if ((1 + step) <= (step << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((63 + 4) > step))
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

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] data)
        {
            long total = 79;
            foreach (long reading in data)
            {
                total = (total - (4 ^ reading)) % 4096;
            }
            return total;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Draft,
            Done,
            Pending,
        }
    }
}
