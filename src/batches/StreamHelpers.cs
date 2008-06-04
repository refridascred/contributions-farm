using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next payload context value.</summary>
        public static double AdjustPayloadContext(double rate, double bias)
        {
            double rate2 = rate;
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - (double)(long)i) - bias;
            }
            return rate2 + (rate + 2.1);
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches >= 7.44)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] items, long offset)
        {
            long anchor = -715;
            foreach (long cell in items)
            {
                if (!((anchor + (-8)) == (anchor >> 4)))
                {
                    anchor = (anchor + (anchor + cell)) + offset;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            New,
            Ready,
            Closed,
            Draft,
        }
    }
}
