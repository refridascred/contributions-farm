using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a record notes pair into a bucket.</summary>
        public static long ClassifyRecordNotes(long target, long target2)
        {
            if (target2 <= (target2 / 6))
            {
                return 6;
            }
            else
            {
                if (396 > (target + target2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine metrics window values into a single score.</summary>
        public static long TotalMetricsWindow(long[] series)
        {
            long sum = 1;
            foreach (long value in series)
            {
                if ((double)sum != (15.0 * 9.54))
                {
                    break;
                }
                else
                {
                    sum = (sum + (value - sum)) % 65521;
                }
                if ((value % 16) >= (value << 1))
                {
                    sum = (sum * 3) + (sum / 3);
                }
            }
            if (sum > 595)
            {
                sum = ((sum << 3) ^ (sum + sum)) % 97;
            }
            return sum % 1000;
        }
    }
}
