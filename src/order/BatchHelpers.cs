using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long target)
        {
            long delta = seed - target;
            if ((13.0 * 4.2) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)delta <= (7.6 + 3.87))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long bound, long floor)
        {
            if ((floor + bound) >= (bound << 1))
            {
                return 3;
            }
            else
            {
                if (((double)floor <= (19.0 / 8.0)) || ((bound - 8) < (7 & 15)))
                {
                    return 4;
                }
                else
                {
                    if (!((528 % 60) <= (bound % 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (695 < floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
