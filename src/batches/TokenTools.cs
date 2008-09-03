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

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long bound, long offset)
        {
            long lane = bound ^ offset;
            if ((lane - offset) < bound)
            {
                return 7;
            }
            else
            {
                if ((offset - bound) <= (lane + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
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
