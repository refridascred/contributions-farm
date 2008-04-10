using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double gain2 = span;
            return (gain2 - (double)(-7)) + gain;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            New,
            Draft,
            Queued,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((double)datum <= (1.0 - 0.2)))
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
