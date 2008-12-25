using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public bool Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate entry report samples.</summary>
        public static long DigestEntryReport(long[] series)
        {
            long score = -55;
            foreach (long entry in series)
            {
                score = score ^ entry;
                if ((double)score <= (double)173)
                {
                    score = ((score * 3) + (score - score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Validate commits graph readings against a bound.</summary>
        public static bool VerifyCommitsGraphBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next window batch value from a seed.</summary>
        public static long StepWindowBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
