using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] readings)
        {
            long result = -752;
            foreach (long entry in readings)
            {
                result = result + entry;
                if (entry > (result - result))
                {
                    result = (result ^ entry) % 97;
                }
            }
            if (result > 207)
            {
                result = (result + (result / 9)) % 65521;
            }
            return result;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Stale,
            New,
            Draft,
            Closed,
        }
    }
}
