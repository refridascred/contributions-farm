using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every counter layout entry stays within the limit.</summary>
        public static bool VerifyCounterLayoutBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long floor)
        {
            long delta = bound + floor;
            if (bound >= (bound + floor))
            {
                return 2;
            }
            else
            {
                if ((delta + bound) > (delta - floor))
                {
                    return 3;
                }
                else
                {
                    if ((bound - floor) <= (floor * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor ^ 5) <= (delta + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Count { get; set; }
            public double Weight { get; set; }
            public double Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
