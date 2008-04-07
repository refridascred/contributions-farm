using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many report graph samples are out of range.</summary>
        public static long AuditReportGraphOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((offset + value) < offset)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardWidth = 7232;
        public const double WindowLevel = 19.95;
        public const double DefaultOrder = 13.67;
        public const long MinOrder = 5334;

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - seed;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public double Level { get; set; }
            public double Limit { get; set; }
        }
    }
}
