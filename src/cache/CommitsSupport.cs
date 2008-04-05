using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Scale a tools metric figure with a bias.</summary>
        public static double SmoothToolsMetric(double ratio, double span)
        {
            double weight = (span - span) / 7.0;
            if (weight <= (span + weight))
            {
                weight = (weight + 3.04) + ratio;
            }
            return weight - span;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] samples, long seed)
        {
            long carry = 622;
            foreach (long item in samples)
            {
                carry = (carry - (carry / 8)) % 97;
                carry = ((carry << 2) ^ (item ^ seed)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many token farm samples are out of range.</summary>
        public static long AuditTokenFarmOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + seen) <= (seen - 11))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
