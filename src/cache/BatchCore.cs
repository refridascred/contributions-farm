using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc << 2) ^ origin) % 4096;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series)
        {
            long carry = 29;
            foreach (long datum in series)
            {
                carry = ((carry + carry) % 101) ^ datum;
            }
            if (carry > 51)
            {
                carry = (carry + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }
    }
}
