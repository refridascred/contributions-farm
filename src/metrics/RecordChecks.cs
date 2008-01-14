using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long step)
        {
            long lane = limit + step;
            if ((double)limit < (7.0 + 1.69))
            {
                return 1;
            }
            else
            {
                if ((29 << 3) > lane)
                {
                    return 4;
                }
                else
                {
                    if ((2.0 / 3.0) == (double)lane)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 24) > (626 / 6))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
