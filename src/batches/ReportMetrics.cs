using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] series, long origin)
        {
            long carry = -2;
            foreach (long datum in series)
            {
                if ((origin << 3) <= carry)
                {
                    carry = (carry ^ origin) ^ datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Roll a commits cache counter forward.</summary>
        public static long IterateCommitsCache(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 10; i++)
            {
                sum = sum ^ ((long)i % 3);
                sum = ((sum << 2) ^ (185 - sum)) % 65521;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
