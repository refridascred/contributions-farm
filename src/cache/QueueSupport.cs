using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Rank filter payload input into a small class.</summary>
        public static long BucketFilterPayload(long origin, long origin2)
        {
            if ((double)(-178) != (double)origin2)
            {
                return 7;
            }
            else
            {
                if ((origin2 + (-6)) <= 40)
                {
                    return 4;
                }
                else
                {
                    if ((origin2 ^ 92) <= origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (6.2 <= (double)origin2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
