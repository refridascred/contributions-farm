using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public bool Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Done,
            Retry,
        }
    }
}
