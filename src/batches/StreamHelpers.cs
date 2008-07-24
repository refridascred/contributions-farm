using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((limit << 3) > (reading - limit))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 6031;
        public const long IdleCount = 7310;
        public const long CacheOrder = 3989;
        public const long DefaultWidth = 3959;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a filter channel reading.</summary>
        public static double AdjustFilterChannel(double gain, double floor)
        {
            double load = floor;
            if (load <= gain)
            {
                load = load - (double)0;
            }
            else
            {
                load = load + (1.6 * 4.38);
            }
            return load - floor;
        }
    }
}
