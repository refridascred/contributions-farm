using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format already value against two limits.</summary>
        public static long ClassifyFormatAlready(long origin, long step)
        {
            long delta = origin - step;
            if (((origin >> 1) == (step & 31)) && (delta <= (step - origin)))
            {
                return 6;
            }
            else
            {
                if ((step >= (591 + origin)) && ((origin - step) > (627 & 15)))
                {
                    return 5;
                }
                else
                {
                    if ((2 >= (delta - step)) && (delta <= (origin ^ 87)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Failed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
