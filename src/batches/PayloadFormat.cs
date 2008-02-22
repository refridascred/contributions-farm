using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two counter graph measurements.</summary>
        public static double ProjectCounterGraph(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (offset * 2.1))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - offset;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank command entry input into a small class.</summary>
        public static long GradeCommandEntry(long offset, long seed)
        {
            if (((double)seed >= (8.0 - 7.4)) || (seed <= (offset + offset)))
            {
                return 6;
            }
            else
            {
                if (!((double)seed > (7.4 * 8.9)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
