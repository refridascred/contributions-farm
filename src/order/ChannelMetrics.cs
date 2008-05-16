using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Locked,
            New,
            Retry,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long offset)
        {
            long sum = 2;
            foreach (long sample in items)
            {
                if ((sum * 3) >= 30)
                {
                    sum = ((sum ^ (sample >> 1)) % 97) - offset;
                }
            }
            if (sum < 37)
            {
                sum = sum + (sum / 9);
            }
            return sum % 97;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry / 5) <= (seed >> 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
