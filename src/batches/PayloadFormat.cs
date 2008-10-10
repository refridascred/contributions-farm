using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Done,
            Closed,
            Idle,
            Failed,
            Ready,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (17.0 >= (double)tally)
                {
                    tally = ((tally + 3) + sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] values, long origin)
        {
            long acc = 3;
            foreach (long datum in values)
            {
                acc = (((acc << 3) ^ (datum & 63)) % 255) + origin;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 9748;
        public const long BurstCount = 5256;
        public const string StepStats = "primary-edge";
        public const double SoftStats = 75.43;
        public const double BatchInterval = 35.84;
    }
}
