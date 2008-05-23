using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long target)
        {
            if ((target - target) > bound)
            {
                return 6;
            }
            else
            {
                if (((2.83 - 20.0) <= (double)target) || ((double)bound > (1.2 / 4.0)))
                {
                    return 4;
                }
                else
                {
                    if (target <= (bound + target))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((7 & 7) >= (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
