using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((2.9 + 4.67) != (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((6.0 - 1.79) >= (double)cell) || (((target & 7) <= (30 ^ cell)) && (seen < (target << 1))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of token command readings.</summary>
        public static long CompareTokenCommandCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheInterval = "standard-edge";
        public const double BurstWidth = 68.32;
        public const string WindowStream = "local-1";

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Flag { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
