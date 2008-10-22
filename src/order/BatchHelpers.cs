using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double rate = 5.09;
            if (rate <= (double)4)
            {
                rate = rate + (span - rate);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (6.0 - gain)) - (double)(long)i;
            }
            return rate - (rate + span);
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
