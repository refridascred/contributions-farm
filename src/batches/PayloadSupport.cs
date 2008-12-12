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

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseScore = 8782;
        public const long CacheRoute = 6500;
        public const long BatchSpan = 4212;

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
