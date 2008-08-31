using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Owner { get; set; }
            public string Mode { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long bound, long seed)
        {
            if (((double)seed != (10.0 + 18.0)) || ((bound + 91) >= bound))
            {
                return 7;
            }
            else
            {
                if (6.0 >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (!((123 >> 2) >= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed >= (bound + bound))
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
    }
}
